using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine.Interfaces
{
    public interface IPhysicalProduct : IProduct
    {
        void GeneratePackingSlipForShipping();

        void PayCommisionToAgent(int commisionInPercentage);
    }
}
