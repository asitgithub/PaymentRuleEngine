using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine
{
    public interface IPhysicalProduct : IProduct
    {
        void GeneratePackingSlipForShipping();

        void PayCommisionToAgent(int commisionInPercentage);
    }
}
