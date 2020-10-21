using MediatR;
using ModernArchitectureShop.Store.Application.UseCases.SearchProducts;

namespace ModernArchitectureShop.Store.Infrastructure.UseCases.SearchProducts
{
    public class SearchProducts : IRequest<SearchProductsCommandResponse>, ISearchProducts
    {
        public string Filter { get; set; } = string.Empty;

        public int PageIndex { get; set; } = 1;

        public int PageSize { get; set; } = 10;
    }
}
