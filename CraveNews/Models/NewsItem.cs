namespace CraveNews
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsItem")]
    public partial class NewsItem
    {
        public int newsItemId { get; set; }

        [Required]
        public string newsItemHeadline { get; set; }

        [Required]
        public string newsItemDescription { get; set; }

        public string newsItemPubDate { get; set; }

        public string newsItemImageSrc { get; set; }

        [Required]
        public string newsItemLink { get; set; }

        public string newsItemSource { get; set; }

        public string newsItemTechNonTech { get; set; }
    }
}
