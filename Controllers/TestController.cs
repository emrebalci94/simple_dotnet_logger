using Microsoft.AspNetCore.Mvc;

namespace sample_dotnet_logger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet("Error")]
        public IActionResult Error()
        {
            throw new System.Exception("Hata Oluştu");
        }
    }
}