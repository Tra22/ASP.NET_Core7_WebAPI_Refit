using Asp.Versioning;
using ASP.NET_Core7_WebAPI_Refit.Services;
using ASP.NET_Core7_WebAPI_Refit.Dtos.User;
using ASP.NET_Core7_WebAPI_Refit.Payloads.Globals;
using ASP.NET_Core7_WebAPI_Refit.Payloads.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core7_WebAPI_Refit.Controllers {
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : ControllerBase {
        private readonly IUsersApiClientService _userApiClient;
        public UserController (IUsersApiClientService usersApiClientService){
            this._userApiClient = usersApiClientService;
        }
    
        [HttpGet]
        public async Task<Response<IEnumerable<UserDto>>> GetAllUsersQueryParam([FromQuery] QueryParam queryParam){
            return new Response<IEnumerable<UserDto>>() { Message= "Successfully fetch users by query.", Data= await _userApiClient.GetAllUsersQuery(queryParam) };
        }
        [HttpGet("{id}")]
        public async Task<Response<UserDto>> GetUserById (int id){
            return new Response<UserDto>() { Message= "Successfully fetch user by id.", Data= await _userApiClient.GetUserById(id) };
        }
        [HttpPost]
        public async Task<Response<UserDto>> CreateUser ([FromBody] CreateUserDto createUserDto){
            return new Response<UserDto>() { Message= "Successfully created user.", Data= await _userApiClient.CreateUser(createUserDto) };
        }
        [HttpPut]
        public async Task<Response<UserDto>> UpdateUser ([FromBody] UpdateUserDto updateUserDto){
            return new Response<UserDto>() { Message= "Successfully updated user.", Data= await _userApiClient.UpdateUser(updateUserDto) };
        }
        [HttpDelete("{id}")]
        public async Task<Response<UserDto>> DeleteUserById (int id){
            return new Response<UserDto>() { Message= "Successfully deleted user.", Data= await _userApiClient.DeleteUserById(id) };
        }
    }
}