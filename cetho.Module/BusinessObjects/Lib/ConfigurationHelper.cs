using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cetho.Module.BusinessObjects
{
    public static class ConfigurationHelper
    { 
        public static string GetByName(string configKeyName)
        {
            var config = new ConfigurationBuilder()
              //  .AddJsonFile("appsettings.json")
                .Build();

            IConfigurationSection section = config.GetSection(configKeyName);

            return section.Value;
        }
    }
}
