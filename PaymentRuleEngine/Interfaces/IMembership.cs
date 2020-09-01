using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine
{
    public interface IMembership : IProduct
    {
        void ActivateMembership(MembershipType mt);
    }
}
