using ASP.NET_Core7_WebAPI_Refit.Dtos.User;
using ASP.NET_Core7_WebAPI_Refit.Payloads.Requests;
using Refit;

namespace ASP.NET_CORE7_API_OAUTH2_RESOURCE.Services {
    public interface IUsersApiClientService {
        [Get("/users")]
        Task<IEnumerable<UserDto>> GetAllUsersQuery(QueryParam queryParam);
        [Get("/users/{id}")]
        Task<UserDto> GetUserById(int id);
        [Post("/users")]
        Task<UserDto> CreateUser(CreateUserDto createUserDto);
        [Put("/users")]
        Task<UserDto> UpdateUser(UpdateUserDto updateUserDto);
        [Delete("/users/{id}")]
        Task<UserDto> DeleteUserById(int id);
    }
}