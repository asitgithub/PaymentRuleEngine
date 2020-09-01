using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine
{
    public class Book : IBook
    {
        private readonly IPackingSlipGenerator _generateSlipService;
        public Book(IPackingSlipGenerator generateSlipService)
        {
            _generateSlipService = generateSlipService;
        }
        public void GeneratePackingSlipForRoyaltyDepartment()
        {
            _generateSlipService.GeneratePackingSlip(PackingSlipTypes.RoyaltyDepartment);
        }

        public void GeneratePackingSlipForShipping()
        {
            _generateSlipService.GeneratePackingSlip(PackingSlipTypes.Shipping);
        }

        public void MakePayment()
        {
            Console.WriteLine("Payment made for Book.");
            GeneratePackingSlipForShipping();
            GeneratePackingSlipForRoyaltyDepartment();
            PayCommisionToAgent(10);
        }

        public void PayCommisionToAgent(int commisionInPercentage)
        {
            Console.WriteLine(commisionInPercentage + "% commision paid to agent for the book.");
        }
    }
}
