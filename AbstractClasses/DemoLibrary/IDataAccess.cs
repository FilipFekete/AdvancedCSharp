using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{   
    //replaced IDataAccess with abstract DataAccess
    public interface IDataAccess
    {
        string LoadConnectionString(string name);
        void LoadData(string sql);
        void SaveData(string sql);
    }
}
