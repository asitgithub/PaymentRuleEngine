using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine
{
    public class EmailNotifier : IEmailNotifier
    {
        public void NotifyUser(string emailContent)
        {
            Console.WriteLine("User notified via Email!");
        }
    }
}
