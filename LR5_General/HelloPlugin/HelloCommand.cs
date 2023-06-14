using PluginBase;
using System;
using System.Windows.Input;

namespace HelloPlugin
{
    public class HelloCommand : PluginBase.ICommand
    {
        public string Name { get => "hello"; }
        public string Description { get => "Displays hello message."; }

        public int Execute(string[]? args = null)
        {
            if (args != null && args.Length > 0)
            {
                foreach (var item in args)
                {
                    Console.WriteLine("Hello {0}!!!", item);
                }
            } else
            {
                Console.WriteLine("Hello !!!");
            }
            
            return 0;
        }
    }
}