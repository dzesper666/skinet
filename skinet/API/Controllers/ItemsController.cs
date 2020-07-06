using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public string GetItems()
        {
            return "list of items";
        }

        [HttpGet("{id}")]
        public string GetItem(int id)
        {
            return "single item";
        }
    }
}