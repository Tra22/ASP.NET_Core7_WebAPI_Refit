using Asp.Versioning;
using ASP.NET_CORE7_API_OAUTH2_RESOURCE.Services;
using ASP.NET_Core7_WebAPI_Refit.Dtos.Product;
using ASP.NET_Core7_WebAPI_Refit.Payloads.Globals;
using ASP.NET_Core7_WebAPI_Refit.Payloads.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE7_API_OAUTH2_RESOURCE.Controllers {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductController : ControllerBase {
        private readonly IProductsApiClientService _productApiClient;
        public ProductController (IProductsApiClientService productsApiClientService){
            this._productApiClient = productsApiClientService;
        }
    
        [HttpGet]
        public async Task<Response<IEnumerable<ProductDto>>> GetAllProductsQueryParam([FromQuery] QueryParam queryParam){
            return new Response<IEnumerable<ProductDto>>() { Message= "Successfully fetch products by query.", Data= await _productApiClient.GetAllProductsQuery(queryParam) };
        }
        [HttpGet("category/{category}")]
        public async Task<Response<IEnumerable<ProductDto>>> GetAllProductsByCategory(string category){
            return new Response<IEnumerable<ProductDto>>() { Message= "Successfully fetch products by query.", Data= await _productApiClient.GetAllProductsByCategory(category) };
        }
        [HttpGet("{id}")]
        public async Task<Response<ProductDto>> GetProductById (int id){
            return new Response<ProductDto>() { Message= "Successfully fetch product by id.", Data= await _productApiClient.GetProductById(id) };
        }
        [HttpPost]
        public async Task<Response<ProductDto>> CreateProduct ([FromBody] CreateProductDto createProductDto){
            return new Response<ProductDto>() { Message= "Successfully created product.", Data= await _productApiClient.CreateProduct(createProductDto) };
        }
        [HttpPut]
        public async Task<Response<ProductDto>> UpdateProduct ([FromBody] UpdateProductDto updateProductDto){
            return new Response<ProductDto>() { Message= "Successfully updated product.", Data= await _productApiClient.UpdateProduct(updateProductDto) };
        }
        [HttpDelete("{id}")]
        public async Task<Response<ProductDto>> DeleteProductById (int id){
            return new Response<ProductDto>() { Message= "Successfully deleted produtc.", Data= await _productApiClient.DeleteProductById(id) };
        }
    }
}