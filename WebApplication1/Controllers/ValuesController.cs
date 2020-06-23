using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IService _service;
        public ValuesController(IService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("Add")]
        public decimal Add(decimal itemA, decimal itemB)
            => _service.Add(itemA, itemB);


        [HttpGet]
        [Route("Minus")]
        public decimal Minus(decimal itemA, decimal itemB)
            => _service.Minus(itemA, itemB);

        [HttpGet]
        [Route("Times")]
        public decimal Times(decimal itemA, decimal itemB)
            => _service.Times(itemA, itemB);

        [HttpGet]
        [Route("Divided")]
        public decimal Divided(decimal itemA, decimal itemB)
            => _service.Divided(itemA, itemB);
    }
}
