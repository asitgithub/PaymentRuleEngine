using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PaymentRuleEngine;

namespace PaymentRuleEngineTest
{
    public class EmailNotifierTest
    {
        [Fact]
        public void NotifyUsertest()
        {
            var notification = new EmailNotifier();
            notification.NotifyUser("Email Sent Succesfully");
            return;
        }
    }
}
