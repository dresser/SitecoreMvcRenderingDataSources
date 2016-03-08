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
            var model = new TestModel(RenderingContext.Current.ContextItem,
                "RenderingContext.Current.ContextItem",
                GetDataSourcePath(RenderingContext.Current));
            return View("TestRendering", model);
        }

        public ActionResult PageContextRendering()
        {
            var model = new TestModel(RenderingContext.Current.PageContext.Item,
                "RenderingContext.Current.PageContext.Item", 
                GetDataSourcePath(RenderingContext.Current));
            return View("TestRendering", model);
        }

        public ActionResult RenderingItemRendering()
        {
            var model = new TestModel(RenderingContext.Current.Rendering.Item,
                "RenderingContext.Current.Rendering.Item",
                GetDataSourcePath(RenderingContext.Current));
            return View("TestRendering", model);
        }

        private string GetDataSourcePath(RenderingContext renderingContext)
        {
            var datasourceItem =
                renderingContext.PageContext.Database.GetItem(renderingContext.Rendering.DataSource);
            if (datasourceItem == null)
            {
                return "";
            }
            return datasourceItem.Paths.ContentPath;
        }
    }
}