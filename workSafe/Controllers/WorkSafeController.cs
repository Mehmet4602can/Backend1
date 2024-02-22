using Microsoft.AspNetCore.Mvc;

namespace workSafe.Controllers
{
    public class WorkSafeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public FileResult jsonResim()
        {
            return File("~/imge/isguvenligi.jpg", "image/jpg");
        }
        [Route("WorkSafe/gt/{id}")]
        public string gt(int id)
        {
            return $"geri gönder = {id}";
        }
    }
}
