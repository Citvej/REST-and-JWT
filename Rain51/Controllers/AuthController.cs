using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Rain51.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private IConfiguration _configuration;
        public AuthController(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }

        [HttpPost("token")]
        public IActionResult Token([FromBody] TokenRequest request)
        {
            var header = Request.Headers["Authorization"];
            if (header.ToString().StartsWith("Basic"))
            {
                var credValue = header.ToString().Substring("Basic ".Length).Trim();
                var usernameAndPassenc = Encoding.UTF8.GetString(Convert.FromBase64String(credValue)); //dobim v formatu user:pass
                var usernameAndPass = usernameAndPassenc.Split(":");
                if (usernameAndPass[0] == "admin" && usernameAndPass[1] == "pass")
                {


                    var claimsdata = new[] { new Claim(ClaimTypes.Name, usernameAndPass[0]), new Claim(ClaimTypes.Role, "Admin") };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Key"]));
                    var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                    var token = new JwtSecurityToken(
                        issuer: "mysite.com",
                        audience: "mysite.com",
                        expires: DateTime.Now.AddMinutes(30),
                        claims: claimsdata,
                        signingCredentials: signInCred
                        );

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                    //sessionStorage.setItem('key', );

                    return Ok(tokenString);
                }
                if (usernameAndPass[0] == "user" && usernameAndPass[1] == "pass")
                {


                    var claimsdata = new[] { new Claim(ClaimTypes.Name, usernameAndPass[0]), new Claim(ClaimTypes.Role, "User") };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Key"]));
                    var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                    var token = new JwtSecurityToken(
                        issuer: "mysite.com",
                        audience: "mysite.com",
                        expires: DateTime.Now.AddMinutes(30),
                        claims: claimsdata,
                        signingCredentials: signInCred
                        );

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                    return Ok(tokenString);
                }
            }
            return BadRequest("Could not verify username and password.");
            //return View();
        }

        public class TokenRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}