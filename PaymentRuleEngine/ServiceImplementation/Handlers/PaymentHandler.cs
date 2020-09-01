using PaymentRuleEngine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    public class PaymentHandler
    {
        private readonly List<IProduct> _payments;

        public PaymentHandler(IPackingSlipGenerator slipService, IEmailNotifier _notifier)
        {
            _payments = new List<IProduct>();

            _payments.Add(new PhysicalProduct(slipService));
            _payments.Add(new Book(slipService));
            _payments.Add(new MembershipHandler(MembershipType.Regular, _notifier));
            _payments.Add(new MembershipHandler(MembershipType.Premium, _notifier));
            _payments.Add(new VideoLearningHandler(VideoTypes.LearningToSki));
            _payments.Add(new VideoLearningHandler(VideoTypes.Others));
        }
        public void InitializePayment()
        {
            Console.WriteLine("This is Rule Engine app");
            Console.WriteLine();

            if (_payments != null)
            {
                _payments.ForEach(pmt =>
                {
                    Console.WriteLine();
                    pmt.MakePayment();
                    Console.WriteLine();
                });
            }
            Console.ReadLine();
        }


    }
}
