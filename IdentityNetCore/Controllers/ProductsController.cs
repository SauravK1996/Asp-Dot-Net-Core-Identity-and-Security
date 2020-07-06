using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityNetCore.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [Route("List")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public List<Product> GetList()
        {
            var chair = new Product { Name = "Chair", Price = 100 };
            var desk = new Product { Name = "Desk", Price = 50 };

            return new List<Product> { chair, desk };
        }
    }
}