using Product.Domain.Common;
using Product.Domain.Entities;
using Product.Domain.Events;
using System.Collections.Generic;

namespace Product.Domain
{
    public class Product : BaseEntity, IHasDomainEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public bool IsFeatured { get; set; }
        public List<Image> Images { get; set; }

        private bool _active;
        public bool Active
        {
            get => _active;
            set
            {
                if (value == true && _active == false)
                {
                    DomainEvents.Add(new ProductAvailableEvent(this));
                }

                _active = value;
            }
        }

        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}
