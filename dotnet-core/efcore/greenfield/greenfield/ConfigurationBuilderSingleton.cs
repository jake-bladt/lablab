using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Microsoft.Extensions.Configuration;

namespace greenfield
{
    public sealed class ConfigurationBuilderSingleton
    {
        private static ConfigurationBuilderSingleton _instance = null;
        private static object InstanceLock = new object();
        private static IConfigurationRoot _configuration;

        private ConfigurationBuilderSingleton()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
        }

        public static ConfigurationBuilderSingleton Instance
        {
            get
            {
                lock(InstanceLock)
                {
                    if (null == _instance) _instance = new ConfigurationBuilderSingleton();
                }
                return _instance;
            }
        }

        public static IConfigurationRoot ConfigurationRoot
        {
            get
            {
                if (null == _configuration)
                {
                    var x = ConfigurationBuilderSingleton.Instance;
                }
                return _configuration;
            }
        }
    }
}
