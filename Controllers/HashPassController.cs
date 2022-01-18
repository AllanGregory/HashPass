using Microsoft.AspNetCore.Mvc;

namespace HashPass.Controllers
{
    public class HashPassController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAllHashPass()
        {
            return Ok();
        }
    }
}