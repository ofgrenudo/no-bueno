using System;
namespace no_bueno.emailManager.interfaces
{
    public interface iEnvironmentConfiguration
    {
        string smtpAddress(string? input);
        string smtpUser(string? input);
        string smtpPassword(string? input);
        bool? smtpSSL(bool? input);
        int? smtpPort(int? input);
    }
}

