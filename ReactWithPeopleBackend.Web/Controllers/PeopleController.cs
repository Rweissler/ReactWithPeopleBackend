using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Configuration;
using ReactWithPeopleBackend.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactWithPeopleBackend.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private string _connectionString;

        public PeopleController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConStr");
        }
        
        [Route("getAll")]
        public List<Person> GetAll()
        {
            var repo = new PeopleDataRepo(_connectionString);
            repo.Add(person);
        }

    }
}
