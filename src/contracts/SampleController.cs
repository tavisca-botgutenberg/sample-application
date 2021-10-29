namespace SampleAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpPost]
        //[Route("create")]
        public ActionResult CreateSample([FromBody]Request request)
        {
            //call to actual service 
            return Ok();
        }

        [HttpGet]
        public ActionResult Get()
        {
            //call to actual service 
            return Ok("ok");
        }
    }
}
