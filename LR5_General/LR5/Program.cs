using AppWithPlugin;
using Microsoft.VisualBasic;
using PluginBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LR5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] com;
            
            do
            {
                Console.WriteLine("Enter the command...");
                com = Console.ReadLine()!.Split(' ');
                string[] pluginPaths = Directory.GetFiles("plugins", "*.dll");
                IEnumerable<ICommand> commands = pluginPaths.SelectMany(pluginPath =>
                {
                    Assembly pluginAssembly = LoadPlugin(pluginPath);
                    return CreateCommands(pluginAssembly);
                }).ToList();

                if (com[0] == "help")
                {
                    Help(commands);
                } else
                {
                    try
                    {
                        
                        ICommand command = commands.FirstOrDefault(c => c.Name == com[0]);
                        if (command == null)
                        {
                            Console.WriteLine("-- {0} --", com[0]);
                            Console.WriteLine("No such command is known.");

                        }
                        else
                        {
                            string[] s = com.Skip(1).ToArray();
                            command.Execute(s);
                            Console.WriteLine();
                        }

                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                
                Console.WriteLine("Click escape to exit, enter to continue:");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static Assembly LoadPlugin(string relativePath)
        {
            // Navigate up to the solution root
            string root = Path.GetFullPath(Path.Combine(
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        Path.GetDirectoryName(
                            Path.GetDirectoryName(
                                Path.GetDirectoryName(typeof(Program).Assembly.Location)))))));

            string pluginLocation = Path.GetFullPath(Path.Combine(root, relativePath.Replace('\\', Path.DirectorySeparatorChar)));
            //Console.WriteLine($"Loading commands from: {pluginLocation}");
            PluginLoadContext loadContext = new PluginLoadContext(pluginLocation);
            return loadContext.LoadFromAssemblyName(new AssemblyName(Path.GetFileNameWithoutExtension(pluginLocation)));
        }

        static IEnumerable<ICommand> CreateCommands(Assembly assembly)
        {
            int count = 0;

            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(ICommand).IsAssignableFrom(type))
                {
                    ICommand result = Activator.CreateInstance(type) as ICommand;
                    if (result != null)
                    {
                        count++;
                        yield return result;
                    }
                }
            }

            if (count == 0)
            {
                string availableTypes = string.Join(",", assembly.GetTypes().Select(t => t.FullName));
                throw new ApplicationException(
                    $"Can't find any type which implements ICommand in {assembly} from {assembly.Location}.\n" +
                    $"Available types: {availableTypes}");
            }
        }

        static void Help(IEnumerable<ICommand> commands)
        {
            Console.WriteLine("Commands: ");
            foreach (ICommand command in commands)
            {
                Console.WriteLine($"{command.Name}\t - {command.Description}");
            }
            Console.WriteLine($"help\t - Displays all available commands and their descriptions.");
        }
    }
}