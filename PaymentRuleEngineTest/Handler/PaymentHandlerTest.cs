using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PaymentRuleEngineTest;
using Moq;

namespace PaymentRuleEngineTest
{
    public class PaymentHandlerTest : IClassFixture<PaymentHandlerFixture>
    {
        private PaymentHandlerFixture _fixture;
        public PaymentHandlerTest(PaymentHandlerFixture fixture)
        {
            _fixture = fixture;

            _fixture.mockNotifier = new Mock<IEmailNotifier>();
            _fixture.mockSlipGenerator = new Mock<IPackingSlipGenerator>();
            _fixture.mockProducts = new Mock<List<IProduct>>();
            _fixture._paymentHandler = new PaymentHandler(_fixture.mockSlipGenerator.Object, _fixture.mockNotifier.Object);
        }

        [Fact]
        public void InitializePaymentMustInitializePayments()
        {
            _fixture._paymentHandler.InitializePayment();
            return;
        }
    }

    public class PaymentHandlerFixture
    {
        public PaymentHandler _paymentHandler;
        public Mock<IPackingSlipGenerator> mockSlipGenerator;
        public Mock<IEmailNotifier> mockNotifier;
        public Mock<List<IProduct>> mockProducts;
    }
}
