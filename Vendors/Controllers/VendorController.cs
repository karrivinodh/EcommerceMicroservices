using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Vendors.Model;
using Vendors.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vendors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
 
        [HttpGet]
        public List<Vendor> Get()
        {
            return VendorServices.Get();
        }
        [HttpPost("VendorRegister")]
        public Vendor Post(Vendor user)
        {
            return VendorServices.Post(user);
        }
        [HttpPost("LoginVendor")]
        public IActionResult PostLogin(Vendor vendorData)
        {
            VendorServices vendorDataService = new VendorServices();
            if (vendorData != null && vendorData.Email != null && vendorData.Password != null)
            {
                var user = vendorDataService.GetVendor(vendorData.Email, vendorData.Password);
                string subject = "MicroServiceJWTAccessToken";
                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
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

