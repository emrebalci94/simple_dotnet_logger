using System;
using Microsoft.AspNetCore.Mvc;
using sample_dotnet_logger.Services;

namespace sample_dotnet_logger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILoggerService _logger;
        public TestController(ILoggerService logger)
        {
            _logger = logger;
        }

        [HttpGet("Error")]
        public IActionResult Error()
        {
            throw new System.Exception("Hata Oluştu");
        }

        [HttpGet("Error2")]
        public IActionResult Test()
        {
            Console.WriteLine("test");
            _logger.LogInfo("test");
            return Ok("Test");
        }
    }
}