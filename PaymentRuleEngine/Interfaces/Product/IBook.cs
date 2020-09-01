using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine
{
    public interface IBook : IPhysicalProduct
    {
        void GeneratePackingSlipForRoyaltyDepartment();
    }
}
