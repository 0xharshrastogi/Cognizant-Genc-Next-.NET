namespace CustomerComLib;

public class CustomerComm
{
    IMailSender _mailSender;

    public CustomerComm(IMailSender mailSender)
    {
        _mailSender = mailSender;
    }

    public bool SendMailToCustomer()
    {
        _mailSender.SendMail("cust123@abc.com", "Some Message");

        return true;
    }
}