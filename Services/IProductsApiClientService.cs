using ASP.NET_Core7_WebAPI_Refit.Dtos.Product;
using ASP.NET_Core7_WebAPI_Refit.Payloads.Requests;
using Refit;

namespace ASP.NET_CORE7_API_OAUTH2_RESOURCE.Services {
    public interface IProductsApiClientService {
        [Get("/products")]
        Task<IEnumerable<ProductDto>> GetAllProductsQuery(QueryParam queryParam);
        [Get("/products/category/{category}")]
        Task<IEnumerable<ProductDto>> GetAllProductsByCategory(string category);
        [Get("/products/{id}")]
        Task<ProductDto> GetProductById(int id);
        [Post("/products")]
        Task<ProductDto> CreateProduct(CreateProductDto createProductDto);
        [Put("/products")]
        Task<ProductDto> UpdateProduct(UpdateProductDto updateProductDto);
        [Delete("/products/{id}")]
        Task<ProductDto> DeleteProductById(int id);
    }
}