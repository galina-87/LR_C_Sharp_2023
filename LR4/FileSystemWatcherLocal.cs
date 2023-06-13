using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4


    
{
    public delegate void dChanged(string[] mes);
    public delegate void dChange(Dir d);

    internal class FileSystemWatcherLocal
    {
        //Свойство OnChange содержит список всех callback-методов подписчиков 
        public event dChanged Changed = delegate { };

        public event dChange Change = delegate { };

        public void RaiseChanged(string[] m)
        {
            //Вызов Change
            //foreach(string s in m)
            //{
                Changed(m);
            //}
           
        }

        public void RaiseChange(Dir d)
        {
            //Вызов Change
            Change(d);
        }

        public void ClearChanged() { Changed = delegate { }; }
    }
}
