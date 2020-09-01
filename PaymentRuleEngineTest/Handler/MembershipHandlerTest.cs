using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PaymentRuleEngineTest;

namespace PaymentRuleEngineTest
{
    public class MembershipHandlerTest
    {
        [Fact]
        public void ActivateMembershipMustActivateMembership()
        {
            var mockNotifier = new Mock<IEmailNotifier>();
            MembershipHandler membership = new MembershipHandler(MembershipType.Regular, mockNotifier.Object);
            membership.ActivateMembership(MembershipType.Regular);
            return;
        }
    }
}
