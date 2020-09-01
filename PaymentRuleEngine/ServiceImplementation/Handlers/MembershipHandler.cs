using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    public class MembershipHandler : IMembership
    {
        private readonly MembershipType _membershipType;
        private readonly IEmailNotifier _emailNotificationClient;

        public MembershipHandler(MembershipType mt, IEmailNotifier emailnotificationclient)
        {
            _membershipType = mt;
            _emailNotificationClient = emailnotificationclient;
        }

        public void ActivateMembership(MembershipType mt)
        {
            if (_membershipType == MembershipType.Regular)
            {
                Console.WriteLine("Membership activated");
            }
            if (_membershipType == MembershipType.Premium)
            {
                Console.WriteLine("Membership upgraded to Premium");
            }
        }

        public void MakePayment()
        {
            string emailMessage = string.Empty;
            if (_membershipType == MembershipType.Regular)
            {
                Console.WriteLine("Payment made for activating membership");
                emailMessage = "Your membership is successfully activated";
            }
            if (_membershipType == MembershipType.Premium)
            {
                Console.WriteLine("Payment made for upgrading membership");
                emailMessage = "Your membership is successfully upgraded";
            }
            ActivateMembership(_membershipType);
            _emailNotificationClient.NotifyUser(emailMessage);
        }
    }
}
