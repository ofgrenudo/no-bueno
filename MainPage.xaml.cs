using System;
using MailKit.Net.Smtp;
using MimeKit;
namespace no_bueno;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void fireBANG(object sender, EventArgs args)
    {
        MimeMessage email = generateEmail();
        using var client = new SmtpClient();
        String address = Preferences.Default.Get("smtpAddress", "");
        String username = Preferences.Default.Get("smtpUsername", "");
        String password = Preferences.Default.Get("smtpPassword", "");
        Int32 port = Int32.Parse(Preferences.Default.Get("smtpPort", ""));

        // Attempt to connect
        if (port == 587) client.Connect(address, port, MailKit.Security.SecureSocketOptions.StartTls);
        if (port == 465) client.Connect(address, port, MailKit.Security.SecureSocketOptions.StartTls);

        client.Authenticate(username, password);
        client.Send(email);
        client.Disconnect(true);
    }

	private MimeMessage generateEmail()
	{
		var email = new MimeMessage();

		Guid messageGUID = Guid.NewGuid();
        String modifiedMessageGuid = messageGUID.ToString();
        modifiedMessageGuid.Replace("-", "").ToUpper();
        email.MessageId = modifiedMessageGuid;

        email.From.Add(new MailboxAddress(kImpersonated.Text, "doesnotmatter@gmail.com"));
		email.To.Add(new MailboxAddress(kVictimDisplayName.Text, kVictimEmail.Text));
		email.Subject = kSubjectLine.Text;

		// Setting Body Content
        var builder = new BodyBuilder();
        builder.TextBody = kEditor.Text;
        email.Body = builder.ToMessageBody();

        return email;
	}
}