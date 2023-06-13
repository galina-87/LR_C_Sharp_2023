using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.IO;

namespace LR4
{
    public class Dir
    {
        string name_dir;
        string[] files;
        string[] dir;
        Dictionary<string, DateTime> date_change;

        public Dir(string d) 
        { 
            name_dir = d;
            files = Directory.GetFiles(d);
            dir = Directory.GetDirectories(d);
            date_change = new Dictionary<string, DateTime>();
            foreach (string f in files)
            {
                date_change.Add(f, Directory.GetLastWriteTime(f));
            }
            foreach (string f in dir)
            {
                date_change.Add(f, Directory.GetLastWriteTime(f));
            }
        }

        public void SetFilesDir()
        {
            Array.Clear(files);
            Array.Clear(dir);
            files = Directory.GetFiles(name_dir);
            dir = Directory.GetDirectories(name_dir);
            date_change = new Dictionary<string, DateTime>();
            foreach (string f in files)
            {
                date_change.Add(f, Directory.GetLastWriteTime(f));
            }
            foreach (string f in dir)
            {
                date_change.Add(f, Directory.GetLastWriteTime(f));
            }
        }

        public string[] GetFilesDir()
        {
            string[] strings = Directory.GetFiles(name_dir); 

            return strings;
        }

        public string[] GetDeleteFilesDir()
        {
            string[] strings = Directory.GetFiles(name_dir);
            string[] stringsdir = Directory.GetDirectories(name_dir);
            List<string> deleted = new List<string>();

            foreach (string s in files)
            {
                if (!strings.Contains(s))
                {
                    deleted.Add(DateTime.Now.ToString() + " Удален файл: " + s);
                    //Console.WriteLine("Удален файл: " + s);
                }
            }

            foreach (string s in dir)
            {
                if (!stringsdir.Contains(s))
                {
                    deleted.Add(DateTime.Now.ToString() + " Удалена папка: " + s);
                    //Console.WriteLine("Удалена папка: " + s);
                }
            }
            //SetFilesDir();
            return deleted.ToArray();
        }

        public string[] GetNewFilesDir()
        {
            string[] strings = Directory.GetFiles(name_dir);
            string[] stringsdir = Directory.GetDirectories(name_dir);

            List<string> newf = new List<string>();

            foreach (string s in strings)
            {
                //Console.WriteLine(s);
                if (!files.Contains(s))
                {
                    newf.Add(DateTime.Now.ToString() + " Новый файл: " + s);
                    //Console.WriteLine("Новый файл: "+s);
                }
            }

            foreach (string s in stringsdir)
            {
                //Console.WriteLine(s);
                if (!dir.Contains(s))
                {
                    newf.Add(DateTime.Now.ToString() + " Новая папка: " + s);
                    //Console.WriteLine("Новая папка: " + s);
                }
            }
            //SetFilesDir();
            return newf.ToArray();
        }

        public string[] GetChangedFilesDir()
        {
            string[] strings = Directory.GetFiles(name_dir);

            List<string> changef = new List<string>();

            foreach (string s in files)
            {
                //Console.WriteLine(s);
                if (strings.Contains(s) && date_change[s] != Directory.GetLastWriteTime(s))
                {
                    changef.Add(DateTime.Now.ToString() + " Изменен файл: " + s);
                    //Console.WriteLine("Изменен файл: " + s);
                }
            }
            //SetFilesDir();
            return changef.ToArray();
        }

        public static void PrintChanges(string[] changes)
        {
            foreach (string s in changes)
            {
                Console.WriteLine(s);
            }

        }
    }
}
