using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGray
{
    public class ConnString
    {
        public string conStr;

        public ConnString(string server, string userID, string password, string database)
        {
            conStr = "server=" + server + ";" + "uid=" + userID + ";" + "pwd=" + password + ";" + "database=" + database + ";";
        }

        public ConnString(string server, string userID, string password)
        {
            conStr = "server=" + server + ";" + "uid=" + userID + ";" + "pwd=" + password + ";";
        }

        public void AddDatabase(string database)
        {
            conStr += "database=" + database + ";";
        }
        
        public string GetConStr()
        {
            return conStr;
        }
    }
}
