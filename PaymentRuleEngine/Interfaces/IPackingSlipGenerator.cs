using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine.Interfaces
{
	public class IPackingSlipGenerator
	{
		void GeneratePackingSlip(PackingSlipDestination _packingSlipDestination);
	}
}
