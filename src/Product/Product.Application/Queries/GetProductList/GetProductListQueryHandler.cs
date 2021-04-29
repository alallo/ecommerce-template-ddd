using MediatR;
using Product.Application.Interfaces;
using Product.Application.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Application.Queries
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, List<ProductModel>>
    {
        private readonly IProductService _productService;

        public GetProductListQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<List<ProductModel>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            var response = await _productService.GetProductListAsync(request.NumberOfPages, request.PageNumber);
            return response;
        }
    }
}
