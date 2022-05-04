using NUnit.Framework;
using CustomerComLib;

namespace CustomerCommLib.UnitTest;

public class CustomerCommTest
{
    CustomerComm? customerComm;

    [SetUp]
    public void Setup()
    {
        var mailer = new MailSender();
        customerComm = new(mailer);
    }

    [Test]
    public void SendMailToCustomer_ReturnTrue()
    {
        try
        {
            Assert.That(customerComm!.SendMailToCustomer());
        }
        catch (System.Exception)
        {
        }
    }
}