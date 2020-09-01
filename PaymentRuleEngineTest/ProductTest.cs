using System;
using Xunit;

namespace PaymentRuleEngineTest
{
    public class PhysicalProductTests : IClassFixture<PhysicalProductFixture>
    {
        private PhysicalProductFixture _fixture;

        public PhysicalProductTests(PhysicalProductFixture fixture)
        {
            _fixture = fixture;

            _fixture.mockSlipGenerator = new Mock<IPackingSlipGenerator>();

            _fixture.physicalProduct = new PhysicalProduct(_fixture.mockSlipGenerator.Object);
        }

        [Fact]
        public void GeneratePackingSlipForShippingMustGenerateSlip()
        {
            _fixture.physicalProduct.GeneratePackingSlipForShipping();
            return;
        }
    }

    public class PhysicalProductFixture
    {
        //public PhysicalProduct physicalProduct;
        //public Mock<IPackingSlipGenerator> mockSlipGenerator;
    }
}
