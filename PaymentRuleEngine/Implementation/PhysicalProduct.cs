using CodingTest.PackingSlipGenerator;
using CodingTest.ProductTypes.PhysicalProducts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    public class PhysicalProduct : IPhysicalProduct
    {
        private readonly IPackingSlipGenerator _printService;
        public PhysicalProduct(IPackingSlipGenerator printService)
        {
            _printService = printService;
        }

        public void GeneratePackingSlipForShipping()
        {
            _printService.GeneratePackingSlip(PackingSlipDestination.Shipping);
        }

        public void MakePayment()
        {
            Console.WriteLine("Payment made for Physical Product.");
            GeneratePackingSlipForShipping();

            //Setting up 10% commision for the agent.
            PayCommisionToAgent(10);
        }

        public void PayCommisionToAgent(int commisionInPercentage)
        {
            Console.WriteLine(commisionInPercentage + "% commision paid to agent for Physical product.");
        }
    }
}
