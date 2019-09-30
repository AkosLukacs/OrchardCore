using System.ComponentModel.DataAnnotations;
using OrchardCore.Sitemaps.Models;

namespace OrchardCore.Contents.SitemapNodes
{
    public class ContentTypesSitemapNode : SitemapNode
    {
        /// <summary>
        /// Description of the sitemap
        /// </summary>
        [Required]
        public string Description { get; set; }
        public ChangeFrequency ChangeFrequency { get; set; } 
        public float Priority { get; set; } = 0.5f;
        public ContentTypeSitemapEntry[] ContentTypes { get; set; } = new ContentTypeSitemapEntry[] { };
        public override bool CanBeChildNode => true;
        public override bool CanSupportChildNodes => false;
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
