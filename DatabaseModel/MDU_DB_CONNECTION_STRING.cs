using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    return "";
            } 
        }
    }
}
