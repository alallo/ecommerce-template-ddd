using MediatR;

namespace Product.Application.Queries
{
    public class GetProductListQuery: IRequest<GetProductListQueryResponse>
    {
        public int NumberOfPages { get; set; }

        public int PageNumber { get; set; }
    }
}
