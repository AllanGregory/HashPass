using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace HashPass.Controllers
{
    public class HashPassController : ControllerBase
    {
        //GET api/HashPass
        [HttpGet]
        public ActionResult GetAllHashPass()
        {
            return Ok();
        }

        //GET api/HashPass/{id}
        [HttpGet("{id}")]
        public ActionResult<IEnumerable> GetHashPassById(int id)
        {
            return Ok();
        }
    }
}