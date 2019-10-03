using Sitecore.Shell.Applications.ContentEditor;

namespace Foundation.MarkdownField.Controls
{
    public class Markdown : Memo
    {
        public Markdown()
        {
            Class = "scContentControlMarkdown scContentControlMemo";
            Attributes.CssStyle.Add("font-family", "Consolas, 'Courier New', Courier, Monaco, monospace");
        }
    }
}