using Markdig;
using Sitecore.Pipelines.RenderField;

namespace Foundation.MarkdownField.Pipelines
{
    public class GetMarkdownFieldValue
    {
        public void Process(RenderFieldArgs args)
        {
            if (args.FieldTypeKey != "markdown")
            {
                return;
            }

            args.DisableWebEdit = true;
            args.Result.FirstPart = Markdown.ToHtml(args.Result.FirstPart);
        }
    }
}