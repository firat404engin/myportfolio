using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FIRATENGIN\\SQLEXPRESS; Initial Catalog=MyPortfolioDb; integrated Security=true;");
            
         }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experiance> Experiances { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skills> Skillss { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoList { get; set; }

    }
}
