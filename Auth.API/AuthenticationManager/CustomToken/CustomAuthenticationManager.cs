using Auth.Demo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.API.AuthenticationManager.CustomToken
{
    public class CustomAuthenticationManager : ICustomAuthenticationManager
    {

        private readonly IUserRepository _userRepository;

        private readonly IDictionary<string, string> tokens = new Dictionary<string, string>();
        public IDictionary<string, string> Tokens => tokens;


        public CustomAuthenticationManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public string Authenticate(string username, string password)
        {
            if (!_userRepository.GetAll().Any(u => u.Username == username && u.Password == password))
            {
                return null;
            }

            var token = Guid.NewGuid().ToString();

            tokens.Add(token, username);

            return token;
        }

    }
}
