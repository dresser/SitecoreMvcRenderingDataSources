using System.Web;

namespace Web.Models
{
    public class TestModel
    {
        public TestModel(Sitecore.Data.Items.Item item)
        {
            Text = new HtmlString(Sitecore.Web.UI.WebControls.FieldRenderer.Render(item, "Text"));
        }

        public IHtmlString Text { get; private set; }
    }
}