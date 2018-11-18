using System;

namespace Cms.Core.Data.Models
{
    public abstract class PageData: ContentBaseData
    {
        public string UrlSegment { get; set; }
    }
}