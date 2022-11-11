using System;
using no_bueno.emailManager;
using System.Text.Json;

namespace no_bueno.tests
{
    public class testEnvironmentConfiguration
    {
        public testEnvironmentConfiguration()
        {
            var myEnvironmentConfiguration = new environmentConfiguration();
            Console.WriteLine($"\r\nTesting initial get :{myEnvironmentConfiguration.smtpPassword()}");
            Console.WriteLine($"Testing Updating the Value :{myEnvironmentConfiguration.smtpPassword("ive changed the password!")}");
            Console.WriteLine($"Checking that update value stuck :{myEnvironmentConfiguration.smtpPassword()}");
        }
    }
}



