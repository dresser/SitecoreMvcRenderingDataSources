using Sitecore.Web.UI.WebControls;
using System.Web;

namespace Web.Models
{
    public class ModelViewRenderingModel : Sitecore.Mvc.Presentation.RenderingModel
    {
        public HtmlString Text
        {
            get { return new HtmlString(FieldRenderer.Render(this.Item, "Text")); }
        }
    }
}