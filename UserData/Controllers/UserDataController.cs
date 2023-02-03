using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using UserDatas.Models;
using UserDatas.Services;

namespace UserDatas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataController : ControllerBase
    {
      


      
        [HttpGet]
        public List<Userdata> Get()
        {
            return UserDataService.Get();
        }
        [HttpPost("RegisterUser")]
        public Userdata Post(Userdata user)
        {
            return UserDataService.Post(user);
        }

        [HttpPost("LoginUser")]
        public IActionResult PostLogin(Userdata _userData)
        {
            UserDataService userDataService= new UserDataService(); 
            if (_userData != null && _userData.Email != null && _userData.Password != null)
            {
                var user = userDataService.PostUser(_userData.Email, _userData.Password);
                string subject = "MicroServiceJWTAccessToken";
                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new [] {
                  new Claim(JwtRegisteredClaimNames.Sub, subject),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                   new Claim("Id", user.Id.ToString()),
                    new Claim("FirstName", user.FirstName),
                    new Claim("LastName", user.LastName),
                    new Claim("Address", user.Address),
                    new Claim("Email", user.Email),
                     new Claim("Mobile",user.Mobile),
                    new Claim("Password",user.Password),
                   };

                    //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    string Key = "SomeJwtUserSecretKey";
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key)); 
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    string issuer = "MicroServiceWebAPI";
                    string audience = "AuthenticatedWebAPIClients";

                    var token = new JwtSecurityToken(issuer, audience, claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

    }
    }

