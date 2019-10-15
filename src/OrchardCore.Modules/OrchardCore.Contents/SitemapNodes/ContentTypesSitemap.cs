using OrchardCore.Sitemaps.Models;

namespace OrchardCore.Contents.SitemapNodes
{
    public class ContentTypesSitemap : Sitemap
    {
        public bool IndexAll { get; set; } = true;
        public ChangeFrequency ChangeFrequency { get; set; }
        public float Priority { get; set; } = 0.5f;
        public ContentTypeSitemapEntry[] ContentTypes { get; set; } = new ContentTypeSitemapEntry[] { };
    }

    public class ContentTypeSitemapEntry
    {
        public string ContentTypeName { get; set; }
        public ChangeFrequency ChangeFrequency { get; set; }
        public float Priority { get; set; }
        public bool TakeAll { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
