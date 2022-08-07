using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
         MyCustomClass _myCustomClass;
         public HomeController(MyCustomClass myCustomClass)
         {
             _myCustomClass = myCustomClass;
         }
         
        [HttpGet]
         async public Task<IActionResult> Index()
         {
             await _myCustomClass.SendMessageAsync("Bu mesaj MyCustomClass kullanılarak HomeController üzerinden gönderilmiştir.");
             return Ok();
         }
    }
}
