using PizzaMaui.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaui.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _connectionDB;

        public UsuarioData UsuarioDataTable { get; set; }

        public SQLiteData(string path)
        {
            _connectionDB = new SQLiteAsyncConnection(path);
            _connectionDB.CreateTableAsync<Usuario>().Wait();

            UsuarioDataTable = new UsuarioData(_connectionDB);
        }
    }
}
