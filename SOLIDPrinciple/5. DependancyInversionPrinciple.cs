using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    //“High-level modules should not depend on low-level modules. Both should depend on abstractions.”

    public interface IEmailSender
    {
        void Send(string message);
    }

    public class GmailSender : IEmailSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email via gmail : {message}");
        }
    }

    public class OutlookSender : IEmailSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email via Outlook: {message}");
        }
    }

    public class EmailService
    {
        private readonly IEmailSender _sender;

        public EmailService(IEmailSender sender)
        {
            _sender = sender;
        }

        public void NotifyUser() 
        { 
            _sender.Send("Hello User! Your email notification.");
        }
    }
}
