using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine
{
    public class PackingSlpGenerator : IPackingSlipGenerator
    {
        public void GeneratePackingSlip(PackingSlipTypes _PackingSlipTypes)
        {
            //Duplicate Packing slip for Royality Deptt. //Requirement 1
            if (_PackingSlipTypes == PackingSlipTypes.Shipping)
            {
                Console.WriteLine("Packing slip generated for Shipping Department");
            }

            //Duplicate Packing slip for Royality Deptt. //Requirement 2
            if (_PackingSlipTypes == PackingSlipTypes.RoyaltyDepartment)
            {
                Console.WriteLine("Duplicate packing slip generated for Royalty Department");
            }
        }
    }
}
