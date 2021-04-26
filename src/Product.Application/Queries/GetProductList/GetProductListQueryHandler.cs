using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Application.Queries
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, GetProductListQueryResponse>
    {
        public Task<GetProductListQueryResponse> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
