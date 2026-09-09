using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [EnableCors("any")]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RestFulController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "获取所有的项目";

        }
        [HttpGet("{i}")]
        public string Get(int i,string name)
        {
            return name+i;

        }

        [HttpPost]
        public string Post(postViewModel pvm)
        {
            return pvm.I + pvm.name;

        }

        [HttpPut]
        public void Put(int id , TestPostEditViewModel model)
        {  

        }

        [HttpDelete]
        public void Delete(int id)
        {
           
        }
    }
}
