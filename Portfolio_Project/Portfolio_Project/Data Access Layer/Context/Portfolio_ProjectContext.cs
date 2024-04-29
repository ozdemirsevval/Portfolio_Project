using Microsoft.EntityFrameworkCore;
using Portfolio_Project.Data_Access_Layer.Entities;

namespace Portfolio_Project.Data_Access_Layer.Context
{
    public class Portfolio_ProjectContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-41905LE\\MSSQLSERVER01;initial Catalog=PortfolioProjectDb;integrated Security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia>SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}
    }
}
