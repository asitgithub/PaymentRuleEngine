using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine.EmailNotification
{
    public interface IEmailNotifier
    {
        void NotifyUser(string emailContent);
    }
}
