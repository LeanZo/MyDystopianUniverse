using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DatabaseModel
{
    public class MDU_DB_CONNECTION_STRING
    {
        public string ConnectionString 
        { 
            get 
            {
                if (ConfigurationManager.AppSettings["SQLSERVER_CONNECTION_STRING_MDU_DB"] != null)
                    return ConfigurationManager.AppSettings["SQLSERVER_CONNECTION_STRING_MDU_DB"].ToString();
                else
                    return File.ReadAllText(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "ConnectionString.txt").Replace("file:\\", "")).ToString();
            } 
        }
    }
}
