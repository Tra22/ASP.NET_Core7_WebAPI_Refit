using ASP.NET_Core7_WebAPI_Refit.Dtos.Cart;
using ASP.NET_Core7_WebAPI_Refit.Payloads.Requests.Cart;
using Refit;

namespace ASP.NET_Core7_WebAPI_Refit.Services {
    public interface ICartsApiClientService {
        [Get("/carts")]
        Task<IEnumerable<CartDto>> GetAllCartsQuery(QueryParamCart queryParam);
        [Get("/carts/user/{userId}")]
        Task<IEnumerable<CartDto>> GetAllCartsByUserId(int userId);
        [Get("/carts/{id}")]
        Task<CartDto> GetCartById(int id);
        [Post("/carts")]
        Task<CartDto> CreateCart(CreateCartDto createCartDto);
        [Put("/carts")]
        Task<CartDto> UpdateCart(UpdateCartDto updateCartDto);
        [Delete("/carts/{id}")]
        Task<CartDto> DeleteCartById(int id);
    }
}