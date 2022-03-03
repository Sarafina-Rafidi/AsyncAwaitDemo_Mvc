using AsyncAwaitDemo_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AsyncAwaitDemo_Mvc.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult Synchronous()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            ContentManagement service = new ContentManagement();
            var content = service.GetContent();
            var count = service.GetCount();
            var name = service.GetName();

            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Asynchronous()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            ContentManagement service = new ContentManagement();
            var contentTask = service.GetContentAsync();
            var countTask = service.GetCountAsync();
            var nameTask = service.GetNameAsync();

            var content = await contentTask;
            var count = await countTask;
            var name = await nameTask;

            watch.Stop();
            ViewBag.WatchMilliseconds = watch.ElapsedMilliseconds;
            return View();
        }
    }
}