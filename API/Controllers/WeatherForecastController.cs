using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VM;
using Core;
using AutoMapper;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMapper _mapper;

        public WeatherForecastController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<UserDTO> Get()
        {
            // var user = new Core.User { Id = 1, Name = "TEST", IsDeleted = true };
            // var res = _mapper.Map<VM.UserDTO>(user);
            // return res;

            var userList = new List<Core.User>();
            userList.Add(new Core.User
            {
                Id = 1,
                Name = "TEST",
                IsDeleted = true,
                City = new Core.City { Id = 10, Name = "London", Country = new Core.Country { Id = 34, Name = "England" } },
                Tokens = new List<Core.Token>{
                    new Core.Token{Id = 1, InsertedDate = DateTime.Now, IsActive = true, Value = "TOKEN KEY ACTIVE" },
                    new Core.Token{Id = 2, InsertedDate = DateTime.Now, IsActive = false, Value = "TOKEN KEY PASSIVE" },
                }
            });
            userList.Add(new Core.User { Id = 2, Name = "TEST2", IsDeleted = true, City = new Core.City { Id = 20, Name = "Ankara", Country = new Core.Country { Id = 44, Name = "Turkey" } } });
            userList.Add(new Core.User { Id = 3, Name = "TEST3", IsDeleted = true, City = new Core.City { Id = 10, Name = "New York", Country = new Core.Country { Id = 14, Name = "USA" } } });
            var res = _mapper.Map<List<VM.UserDTO>>(userList);
            return res;
        }
    }
}
