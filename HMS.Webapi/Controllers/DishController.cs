using AutoMapper;
using HMS.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.Webapi.Controllers
{
    [Route("[controller]")]
    public class DishController : BaseController
    {


        private readonly ILogger<DishController> _logger;

        public DishController(IMapper mapper):base(mapper)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            var dishList = new List<Dish>();
            dishList.Add(new Dish { Name = "Name1" });
            dishList.Add(new Dish { Name = "Name2" });
            dishList.Add(new Dish { Name = "Name3" });
            return Ok(dishList);
        }
    }
}
