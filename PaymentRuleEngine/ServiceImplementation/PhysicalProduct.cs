using PaymentRuleEngine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    public class PhysicalProduct : IPhysicalProduct
    {
        private readonly IPackingSlipGenerator _generateSlipService;
        public PhysicalProduct(IPackingSlipGenerator generateSlipService)
        {
            _generateSlipService = generateSlipService;
        }

        public void GeneratePackingSlipForShipping()
        {
            _generateSlipService.GeneratePackingSlip(PackingSlipTypes.Shipping);
        }

        public void MakePayment()
        {
            Console.WriteLine("Payment made for Physical Product.");
            GeneratePackingSlipForShipping();
            PayCommisionToAgent(10);  //Commission Value %
        }

        public void PayCommisionToAgent(int commisionInPercentage)
        {
            Console.WriteLine(commisionInPercentage + "% commision paid to agent for Physical product.");
        }
    }
}
