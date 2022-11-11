using System;
using System.Text.Json;
using no_bueno.emailManager.interfaces;

namespace no_bueno.emailManager
{
    public class environmentConfiguration : iEnvironmentConfiguration
    {
        string _smtpAddress;
        string _smtpUser;
        string _smtpPassword;
        string _smtpSSL;
        readonly string configurationFilePath = @"appsettings.json";
        readonly string configurationFileRaw = File.ReadAllText(@"appsettings.json");

        public environmentConfiguration()
        {
            /// Load initial values from config file
            var configurationParameters = JsonDocument.Parse(configurationFileRaw);
            smtpPassword(configurationParameters.RootElement.GetProperty("smtpPassword").GetString());
        }

        public string smtpPassword(string? input = "thisisnotvalidpassword")
        {
            /// Get value from config file
            if(input == "thisisnotvalidpassword" && _smtpPassword == null)
            {
                var configurationParameters = JsonDocument.Parse(configurationFileRaw);
                return configurationParameters.RootElement.GetProperty("smtpAddress").GetString();
            }

            /// Update value
            else if (input != "thisisnotvalidpassword")
            {
                _smtpPassword = input;
                return _smtpPassword;
            }

            /// There is a cached value, lets use it.
            else if (input == "thisisnotvalidpassword" && _smtpPassword != null)
            {
                //Console.WriteLine($"environmentConfiguration: {input}");
                //Console.WriteLine($"environmentConfiguration: {_smtpPassword}");
                return _smtpPassword;
            }

            /// None of these worked what do we do? 
            else
            {
                throw new ArgumentException();
            }
        }

        public string smtpPort(string? input)
        {
            throw new NotImplementedException();
        }

        public string smtpSSL(string? input)
        {
            throw new NotImplementedException();
        }

        public string smtpUser(string? input)
        {
            throw new NotImplementedException();
        }
    }
}

