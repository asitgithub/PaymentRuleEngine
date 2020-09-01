using PaymentRuleEngine;
using Moq;
using Xunit;

namespace PaymentRuleEngine
{
    public class ProductTests : IClassFixture<ProductFixture>
    {
        private ProductFixture _fixture;

        public ProductTests(ProductFixture fixture)
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

    public class ProductFixture
    {
        public PhysicalProduct physicalProduct;
        public Mock<IPackingSlipGenerator> mockSlipGenerator;
    }
}
