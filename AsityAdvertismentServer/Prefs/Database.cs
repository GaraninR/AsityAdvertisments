using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsityAdvertismentServer.Prefs
{
    public class Database
    {
        public string connectionString;

        public Database()
        {
            connectionString = "Data Source=192.168.15.11;Initial Catalog=AdvertismentTest;Persist Security Info=False;User ID=sa;Password=Pa$$w0rd";
        }
    }
}
