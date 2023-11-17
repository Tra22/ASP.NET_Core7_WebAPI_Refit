using Asp.Versioning;
using ASP.NET_CORE7_API_OAUTH2_RESOURCE.Services;
using ASP.NET_Core7_WebAPI_Refit.Dtos.Cart;
using ASP.NET_Core7_WebAPI_Refit.Payloads.Globals;
using ASP.NET_Core7_WebAPI_Refit.Payloads.Requests.Cart;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE7_API_OAUTH2_RESOURCE.Controllers {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CartController : ControllerBase {
        private readonly ICartsApiClientService _cartApiClient;
        public CartController (ICartsApiClientService cartsApiClientService){
            this._cartApiClient = cartsApiClientService;
        }
    
        [HttpGet]
        public async Task<Response<IEnumerable<CartDto>>> GetAllCartsQueryParam([FromQuery] QueryParamCart queryParam){
            return new Response<IEnumerable<CartDto>>() { Message= "Successfully fetch users by query.", Data= await _cartApiClient.GetAllCartsQuery(queryParam) };
        }
        [HttpGet("category/{userId}")]
        public async Task<Response<IEnumerable<CartDto>>> GetAllCartsByCategory(int userId){
            return new Response<IEnumerable<CartDto>>() { Message= "Successfully fetch users by query.", Data= await _cartApiClient.GetAllCartsByUserId(userId) };
        }
        [HttpGet("{id}")]
        public async Task<Response<CartDto>> GetCartById (int id){
            return new Response<CartDto>() { Message= "Successfully fetch user by id.", Data= await _cartApiClient.GetCartById(id) };
        }
        [HttpPost]
        public async Task<Response<CartDto>> CreateCart ([FromBody] CreateCartDto createCartDto){
            return new Response<CartDto>() { Message= "Successfully created user.", Data= await _cartApiClient.CreateCart(createCartDto) };
        }
        [HttpPut]
        public async Task<Response<CartDto>> UpdateCart ([FromBody] UpdateCartDto updateCartDto){
            return new Response<CartDto>() { Message= "Successfully updated user.", Data= await _cartApiClient.UpdateCart(updateCartDto) };
        }
        [HttpDelete("{id}")]
        public async Task<Response<CartDto>> DeleteCartById (int id){
            return new Response<CartDto>() { Message= "Successfully deleted user.", Data= await _cartApiClient.DeleteCartById(id) };
        }
    }
}