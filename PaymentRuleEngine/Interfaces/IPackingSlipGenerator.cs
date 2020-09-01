using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine
{
	public interface IPackingSlipGenerator
	{
		void GeneratePackingSlip(PackingSlipTypes _PackingSlipTypes);
	}
}
