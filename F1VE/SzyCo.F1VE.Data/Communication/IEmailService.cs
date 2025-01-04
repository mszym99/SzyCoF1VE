namespace SzyCo.F1VE.Data.Communication;

public interface IEmailService
{
    Task<ItemResult> SendEmailAsync(string to, string subject, string htmlMessage);
}
