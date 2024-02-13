using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence
{
    public static class Configuration
    {
        static public string GetConnectionString
        {
            //Microsoft.Extensions.Configuration.json => SetBasePath
            get
            {
                //ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../../Presentation/E-HekimogluAPI.API"));
                //configurationManager.AddJsonFile("appsettings.json");
                //return configurationManager.GetConnectionString("MySql");
            return "server=localhost;port=3306;database=HekimogluDb;user=root;password=Cngz87007486501;";
            }
        }
    }
}
