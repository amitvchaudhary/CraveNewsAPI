namespace CraveNews
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CraveNews : DbContext
    {
        public CraveNews()
            : base("name=CraveNews")
        {
        }

        public virtual DbSet<NewsItem> NewsItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
