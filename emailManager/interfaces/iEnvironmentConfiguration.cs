using System;
namespace no_bueno.emailManager.interfaces
{
    public interface iEnvironmentConfiguration
    {
        string smtpPort(string? input);
        string smtpUser(string? input);
        string smtpPassword(string? input);
        string smtpSSL(string? input);
    }
}

