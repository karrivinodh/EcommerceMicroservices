using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserDatas.Models;
using UserLoginMS.Models;
using UserLoginMS.Services;

namespace UserLoginMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        [HttpGet]
        public UserData Get(string username) {
            return UserLoginService.Get(username);
        }
        [HttpPost]
        public string Post(UserDataLogin User) { 
            return UserLoginService.Post(User);
        }
    }
}
