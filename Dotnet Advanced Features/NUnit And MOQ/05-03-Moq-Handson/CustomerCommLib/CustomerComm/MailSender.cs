using System.Net;
using System.Net.Mail;

public class MailSender : IMailSender
{
    public bool SendMail(string toAddress, string message)
    {
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

        mail.From = new MailAddress("rastogiharsh@gmail.com");
        mail.To.Add(toAddress);
        mail.Subject = "Test Mail";
        mail.Body = message;

        SmtpServer.Port = 587;
        SmtpServer.Credentials = new NetworkCredential("username", "password");
        SmtpServer.EnableSsl = true;

        SmtpServer.Send(mail);
        return false;
    }
}