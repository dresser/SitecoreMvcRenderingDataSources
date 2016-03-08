using Sitecore.Mvc.Presentation;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Container()
        {
            return View();
        }

        public ActionResult ContextItemRendering()
        {
            var model = new TestModel(RenderingContext.Current.ContextItem);
            return View(model);
        }

        public ActionResult PageContextRendering()
        {
            var model = new TestModel(RenderingContext.Current.PageContext.Item);
            return View(model);
        }

        public ActionResult RenderingItemRendering()
        {
            var model = new TestModel(RenderingContext.Current.Rendering.Item);
            return View(model);
        }
    }
}