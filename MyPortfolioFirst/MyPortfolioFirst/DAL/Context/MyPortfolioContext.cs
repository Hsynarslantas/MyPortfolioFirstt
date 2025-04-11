using Microsoft.EntityFrameworkCore;
using MyPortfolioFirst.DAL.Entities;

namespace MyPortfolioFirst.DAL.Context


{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O65VQEH\\SQLEXPRESS;initial Catalog=MyPortfolioFirst;integrated security = true;trust server certificate = true");
        }
        public DbSet<About>Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experiencee> Experiencees { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> toDoLists { get; set; }

    }
}
