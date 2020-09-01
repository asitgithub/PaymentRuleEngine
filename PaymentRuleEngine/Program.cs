using Microsoft.Extensions.DependencyInjection;
using System;

namespace PaymentRuleEngine
{
	public class Program
	{
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            //Service configuration setup for dependency injection
            serviceCollection.AddTransient<IEmailNotifier, EmailNotifier>();
            serviceCollection.AddTransient<IPackingSlipGenerator, PackingSlpGenerator>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            // This is where dependency is injected and the instance is created
            PaymentHandler ph = ActivatorUtilities.CreateInstance<PaymentHandler>(serviceProvider);

            ph.InitializePayment();
        }
    }
}
