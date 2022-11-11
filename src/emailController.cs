using System;
using MailKit.Net.Smtp;
using MimeKit;


namespace no_bueno.src
{
    /*
     * Whats the purpose of this class?
     * Get Information from env file needed in regards to the email controller.
     * Setup and initialize email controller.
     * 
     */

    public class emailController
    {
        private static MimeMessage email;
        private static string fromEmail;
        private static string fromEmailShort;
        private static string toEmail;
        private static string toEmailShort;

        public void getConfiguration()
        {
            
        } 

        public emailController()
        {

        }
    }
}

