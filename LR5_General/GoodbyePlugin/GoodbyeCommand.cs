using PluginBase;
using System;
using System.Windows.Input;

namespace GoodbyePlugin
{
    public class GoodbyeCommand : PluginBase.ICommand
    {
        public string Name { get => "goodbye"; }
        public string Description { get => "Displays goodbye message."; }

        public int Execute(string[]? args = null)
        {
            if (args != null && args.Length > 0)
            {
                foreach (var item in args)
                {
                    Console.WriteLine("Goodbye {0}!!!", item);
                }
            }
            else
            {
                Console.WriteLine("Goodbye !!!");
            }
            return 0;
        }
    }
}