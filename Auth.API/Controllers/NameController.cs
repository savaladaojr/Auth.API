using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.Demo.DTModels;
using Auth.Demo.Models;
using Auth.Demo.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Demo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        private readonly IJWTAuthenticationManager _authenticationManager;
        private readonly IUserRepository _userRepository;

        public NameController(IJWTAuthenticationManager authenticationManager, IUserRepository userRepository)
        {
            _authenticationManager = authenticationManager;
            _userRepository = userRepository;
        }

        // POST: api/Name/authenticate
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserCredentials userCredentials)
        {
            var token = _authenticationManager.Authenticate(userCredentials.Username, userCredentials.Password);

            if (token == null)
                return Unauthorized();

            return Ok(token);
        }

        // GET: api/Name
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            return Ok(_userRepository.GetAll());
        }

        // GET api/Name/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            User user = _userRepository.GetById(id);
            if (user != null)
            {
                return Ok(new Person() { Id = user.Id, Name = user.Name, Email = user.Email });
            }

            return NotFound();
        }

    }
}
