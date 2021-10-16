using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebmotorsController : ControllerBase
    {
        [HttpGet]
        public string Make() => "value";

        [HttpGet("Model/{MakeId}")]
        public string Model(int makeId) => "value";

        [HttpGet("Version/{ModelId}")]
        public string Version(int modelId) => "value";

        [HttpGet("Vehicles/{Page}")]
        public string Vehicles(int page) => "value";
    }
}
