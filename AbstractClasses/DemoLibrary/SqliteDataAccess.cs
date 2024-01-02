using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqliteDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);

            output += " (from SQLite)";

            return output;
        }

        public override void LoadData(string sql)
        {   
            // Marking method LoadData as override creates an initialization of LoadData - adds body to the method
            Console.WriteLine("Loading SQLite Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
