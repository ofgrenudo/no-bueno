using System;
using System.Text.Json;
using no_bueno.emailManager.interfaces;

namespace no_bueno.emailManager
{
    public class controller
    {
        public controller()
        {
            var myEnvironmentConfiguration = new environmentConfiguration();
            Console.WriteLine($"\r\nSMTP Password: {myEnvironmentConfiguration.smtpPassword()}");
        }
    }
}

