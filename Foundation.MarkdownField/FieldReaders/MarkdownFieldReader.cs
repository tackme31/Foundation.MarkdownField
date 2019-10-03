using Markdig;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.FieldReaders;
using Sitecore.Data.Fields;

namespace Foundation.MarkdownField.FieldReaders
{
    public class MarkdownFieldReader : FieldReader
    {
        public override object GetFieldValue(IIndexableDataField indexableField)
        {
            var field = (Field)(indexableField as SitecoreItemDataField);
            return Markdown.ToHtml(field.Value);
        }
    }
}