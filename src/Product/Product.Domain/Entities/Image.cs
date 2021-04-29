using Product.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Domain.Entities
{
    public class Image: BaseEntity
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string AltText { get; set; }
    }
}
