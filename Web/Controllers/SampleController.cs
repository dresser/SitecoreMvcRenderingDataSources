using System.Web;
using System.Web.Mvc;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using Web.Models;

namespace Web.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult ControllerRendering()
        {
            var model = new ControllerRenderingModel
            {
                Text = new HtmlString(FieldRenderer.Render(RenderingContext.Current.ContextItem, "Text"))
            };
            return View(model);
        }
    }
}