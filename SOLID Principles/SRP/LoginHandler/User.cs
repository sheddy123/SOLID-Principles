using SOLID_Principles.Models;
using System;
using System.Net.Mail;

/*SRP focuses on the principle that every software module, class or function should only have 
 * responsibility for a single part of that program’s functionality. By following this principle 
 * if we change one part of our system, we wouldn’t need to make several other changes because of 
 * the fact that the part we’ve changed is only responsible for a single thing.
 */
namespace SingleResponsibilityPrinciple.LoginHandler
{
        public class User
        {
            private readonly EmailHandler _emailHandler;

            public User(EmailHandler emailHandler)
            {
                _emailHandler = emailHandler;
            }

            public void Register(string email, string password)
            {
                if (!_emailHandler.ValidateEmail(email))
                {
                    Console.WriteLine("Please enter a valid email address");
                    return;
                }
                var user = new UserEntity
                {
                    Email = email,
                    Password = password
                };
                _emailHandler.SendWelcomeEmail(new MailMessage("testsite@test.com", email) { Subject = "Thank you for creating an account" });
                
            }

            
        }
}

