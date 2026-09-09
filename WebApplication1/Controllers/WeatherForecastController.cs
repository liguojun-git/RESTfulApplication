using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services.IServices;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController(IIocService1 iocService1,IIocService2 iocService2)
        {
            IocService1 = iocService1;
            IocService2 = iocService2;
            iocService1.IscopedService.add();
            iocService2.IscopedService.add();
        }

        public IUserService UserService { get; }
        public IIocService1 IocService1 { get; }
        public IIocService2 IocService2 { get; }

        [HttpGet]
        public string Service()
        {
            return "123";
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new postViewModel { I = 1, name = "2"});
        }

        [HttpGet]
        public ActionResult<postViewModel> Get1()
        {
            return Ok(new postViewModel { I = 1, name = "2" });
        }
    }
}
