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
        int? _smtpPort;
        bool? _smtpSSL;
        readonly string configurationFilePath = @"appsettings.json";
        string configurationFileRaw;

        public environmentConfiguration()
        {
            /// Load initial values from config file
            try {
                configurationFileRaw = File.ReadAllText(@"appsettings.json");
                var configurationParameters = JsonDocument.Parse(configurationFileRaw);
                smtpAddress(configurationParameters.RootElement.GetProperty("smtpPassword").GetString());
                smtpUser(configurationParameters.RootElement.GetProperty("smtpPassword").GetString());
                smtpPassword(configurationParameters.RootElement.GetProperty("smtpPassword").GetString());
                smtpSSL(configurationParameters.RootElement.GetProperty("smtpPassword").GetBoolean());
                smtpPort(configurationParameters.RootElement.GetProperty("smtpPassword").GetInt32());
            }
            catch (Exception ex)
            {
                if(ex is FileNotFoundException)
                {
                    Console.WriteLine("\n\nError: File appsettings.json not found. Please check this file and run again.");
                    Console.WriteLine(ex);
                    System.Environment.Exit(0);
                }
                if(ex is InvalidOperationException ex)
                {
                    Console.WriteLine("\n\nError: Please check file type")
                }
            }
        }

        public string smtpAddress(String? input = null)
        {
            if (input != null) { _smtpAddress = input; }
            return _smtpAddress;
        }

        public string smtpPassword(string? input = null)
        {
            if (input != null) { _smtpPassword = input; }
            return _smtpPassword;
        }

        public int? smtpPort(int? input = null)
        {
            if (input != null) { _smtpPort = input; }
            return _smtpPort;
        }

        public bool? smtpSSL(bool? input = null)
        {
            if (input != null) { _smtpSSL = input; }
            return _smtpSSL;
        }

        public string smtpUser(string? input = null)
        {
            if (input != null) { _smtpUser = input; }
            return _smtpUser;

        }
    }
}

