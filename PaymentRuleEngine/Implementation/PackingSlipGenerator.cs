using PaymentRuleEngine.Interfaces;
using PaymentRuleEngine.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine
{
    public class PackingSlpGenerator : IPackingSlipGenerator
    {
        public void GeneratePackingSlip(PackingSlipDestination _packingSlipDestination)
        {
            //Duplicate Packing slip for Royality Deptt. //Requirement 1
            if (_packingSlipDestination == PackingSlipDestination.Shipping)
            {
                Console.WriteLine("Packing slip generated for Shipping Department");
            }

            //Duplicate Packing slip for Royality Deptt. //Requirement 2
            if (_packingSlipDestination == PackingSlipDestination.RoyaltyDepartment)
            {
                Console.WriteLine("Duplicate packing slip generated for Royalty Department");
            }
        }
    }
}
