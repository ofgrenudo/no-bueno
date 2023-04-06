namespace no_bueno;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
        InitializeComponent();
        kSmtpAddress.Text = Preferences.Default.Get("smtpAddress", "");
        kSmtpUsername.Text = Preferences.Default.Get("smtpUsername", "");
        kSmtpPassword.Text = Preferences.Default.Get("smtpPassword", "");
        kSmtpPort.Text = Preferences.Default.Get("smtpPort", "");
    }

    async void applyStone(object sender, EventArgs args)
	{
        Preferences.Default.Set("smtpAddress", kSmtpAddress.Text);
        Preferences.Default.Set("smtpUsername", kSmtpUsername.Text);
        Preferences.Default.Set("smtpPassword", kSmtpPassword.Text);
        Preferences.Default.Set("smtpPort", kSmtpPort.Text);
    }
}
