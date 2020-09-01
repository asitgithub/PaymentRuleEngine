using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine.Interfaces
{
    public interface IMembership : IProduct
    {
        void ActivateMembership(MembershipType mt);
    }

    public enum MembershipType
    {
        Regular = 1,
        Premium = 2
    }
}
