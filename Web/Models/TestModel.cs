using System.Web;

namespace Web.Models
{
    public class TestModel
    {
        public TestModel(Sitecore.Data.Items.Item item, string dataSourceProperty, string currentRenderingDataSource)
        {
            Text = new HtmlString(Sitecore.Web.UI.WebControls.FieldRenderer.Render(item, "Text"));
            Path = item.Paths.ContentPath;
            DataSourceProperty = dataSourceProperty;
            CurrentRenderingDataSource = currentRenderingDataSource;
        }

        public IHtmlString Text { get; private set; }

        public string Path { get; private set; }

        public string DataSourceProperty { get; private set; }

        public string CurrentRenderingDataSource { get; private set; }
    }
}