using System;
using System.Net.Mail;

/*SRP focuses on the principle that every software module, class or function should only have 
 * responsibility for a single part of that program’s functionality. By following this principle 
 * if we change one part of our system, we wouldn’t need to make several other changes because of 
 * the fact that the part we’ve changed is only responsible for a single thing.
 */
namespace SingleResponsibilityPrinciple.LoginHandler
{
    
        public class EmailHandler
        {
            //private readonly SmtpClient _smtpClient;
            //public EmailHandler(SmtpClient smtpClient)
            //{
            //    this._smtpClient = smtpClient;
            //}
            public EmailHandler()
            {

            }

            public virtual bool ValidateEmail(string email)
            {
                return email.Contains("@");
            }

            public void SendWelcomeEmail(MailMessage message)
            {
                string composeMessage = $"Sending Message...{Environment.NewLine}" +
                    $"Sender: {message.From}{Environment.NewLine}" +
                    $"Receiver: {message.To}{Environment.NewLine}" +
                    $"Subject: {message.Subject}{Environment.NewLine}" +
                    $"Message: {message.Body}{Environment.NewLine}" +
                    $"Message sent...";
                Console.WriteLine(composeMessage);
             //   _smtpClient.Send(message);
            }
        }

}

