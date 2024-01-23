using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public abstract class DataAccess
    {   
        // Marking DataAccess as abstract prohibits any instantiation 
        // Cannot create instance but can access anyclass that inherits from DataAccess
        public virtual string LoadConnectionString(string name)
        {   
            // Keyword virtual allows to use the base version as well as overriding it
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }
        public abstract void LoadData(string sql);

        public abstract void SaveData(string sql);
    }
}
