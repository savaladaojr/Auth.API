using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Auth.Demo.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Auth.Demo
{
    public class JWTAuthenticationManager : IJWTAuthenticationManager
    {
        //IDictionary<string, string> users = new Dictionary<string, string>
        //{
        //    { "test1", "password1" },
        //    { "test2", "password2" }
        //};

        private readonly string _tokenKey;
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public string Tokenkey { get; set; }

        public JWTAuthenticationManager(IConfiguration configuration, IUserRepository userRepository, string tokenKey)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _tokenKey = tokenKey;
        }

        public string Authenticate(string username, string password)
        {
            var user = _userRepository.GetAll().FirstOrDefault(w => w.Username == username && w.Password == password);

            if (user == null)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_tokenKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
