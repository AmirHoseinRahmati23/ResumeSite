using Microsoft.EntityFrameworkCore;
using ResumeSite.Data.Entities;
using System;

namespace ResumeSite.Data
{
    public class ResumeSiteContext : DbContext
    {
        public ResumeSiteContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<PersonalInfo> PersonalInfo { get; set; }
        public DbSet<AbilityList> AbilityLists { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> About { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonalInfo>().HasData( new PersonalInfo()
            {
                Id = 1,
                City = "تهران" ,
                Instagram = "https://instagram.com" ,
                Twitter = "twiiter",
                Linkedin = "linkedin" ,
                Name = "نام" ,
                Telegram = "tel" ,
                Work = "نام شغل"
            });

            modelBuilder.Entity<About>().HasData(new About()
            {
                Id = 1,
                AboutMe = "متن درباره من",
                Address = "آدرس",
                Email = "ایمیل",
                Mobile = "شماره موبایل",
                Telephon = "شماره تلفن"
            });

             
            modelBuilder.Entity<Admin>().HasData( new Admin()
            {
                Id = 1,
                UserName = "admin",
                Password = "admin",
                SecoundPassword = "admin2"
            });
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
