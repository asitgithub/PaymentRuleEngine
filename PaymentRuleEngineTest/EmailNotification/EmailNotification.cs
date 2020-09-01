using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PaymentRuleEngineTest;

namespace PaymentRuleEngineTest.EmailNotification
{
    public class EmailNotification
    {
        [Fact]
        public void NotifyUserMustNotifyUser()
        {
            var notification = new EmailNotification();
            notification.NotifyUser("Test Message");
            return;
        }
    }
}
