using System.Collections.Generic;
using MediatR;
using Product.Application.Models;

namespace Product.Application.Queries
{
    public class GetProductListQuery: IRequest<List<ProductModel>>
    {
        public int NumberOfPages { get; set; }

        public int PageNumber { get; set; }
    }
}
