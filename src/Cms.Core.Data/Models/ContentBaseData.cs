using System;

namespace Cms.Core.Data.Models
{
    public abstract class ContentBaseData
    {
        public int Id { get; set; }
        public DateTime PublishDate { get; set; }
        public string Name { get; set; }
    }
}