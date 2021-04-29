using Product.Domain.Common;

namespace Product.Domain.Events
{
    public class ProductAvailableEvent : DomainEvent
    {
        public ProductAvailableEvent(Product product)
        {
            Product = product;
        }

        public Product Product { get; }
    }
}
