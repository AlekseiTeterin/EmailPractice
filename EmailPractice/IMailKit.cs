namespace EmailPractice
{
    public interface IMailKit
    {
        void Send(string fromName,
        string fromEmail,
        string to,
        string subject,
        string bodyHtml);
    }
}