using System;
using MailKit.Net.Smtp;
using MimeKit;

namespace no_bueno
{
    public class emailController
    {
        public emailController()
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("test", "test@company.com"));
            email.To.Add(new MailboxAddress("target", "jeremie.little@ethereal.email"));

            // Get rid of any identifying information within the message ID.
            Guid messageGUID = Guid.NewGuid();
            var messageID = messageGUID.ToString();
            messageID = messageID.Replace("-", "").ToUpper();

            email.MessageId = messageID;




            email.Subject = "Hello World!";
            // if html replace with the following, new TextPart(TextFormat.Html) { Text = body };
            email.Body = new TextPart ("plain")
            {
                Text = @"
    This is a sample email!

With sample text :)

--- Joshua Winters-Brown
                "
            };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("jeremie.little@ethereal.email", "X4f551VBFQERR9UvnJ");

            // Once authenticated we have the abillity to send multiple emails to individuals.
            smtp.Send(email);

            smtp.Disconnect(true);
        }
    }
}

