using BookStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess.Data
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 });

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Gold Book Market",
                    StreetAddress = "Buyuk Ipak Yo'li",
                    City = "Toshkent",
                    State = "O'zbekiston",
                    PhoneNumber = "+998900000000",
                    PostalCode = "100057"
                },
                new Company
                {
                    Id = 2,
                    Name = "Qamar Kitoblar Olami",
                    StreetAddress = "Alisher Navoiy, 3A",
                    City = "Tashkent",
                    State = "O'zbekiston",
                    PhoneNumber = "+998912223344",
                    PostalCode = "100074"
                },
                new Company
                {
                    Id = 3,
                    Name = "Munir",
                    StreetAddress = "Chilonzor, 25-kvartal",
                    City = "Tashkent",
                    State = "Uzbekistan",
                    PhoneNumber = "+998558889977",
                    PostalCode = "100043"
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Ikki eshik orasi",
                    Author = "O'tkir Hoshimov",
                    Description = "Kitob urush vaqtlarini tasvirlagan va o'sha vaqtlardagi voqealarni hamda yashash turmush tarzlarini o'zida aks ettirgan.",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Title = "Ulamolar nazrida vaqtning qadri",
                    Author = "Abdulfattoh Abu G'udda",
                    Description = "O'zining vaqtini va umrini ilmga bag'ishlagan ulamola haqida hamada ularning vaqtdan qanchalik unumli, barakali va salarali foydalanganliklari to'g'risida",
                    ISBN = "EKD99456001",
                    ListPrice = 40,
                    Price = 55,
                    Price50 = 85,
                    Price100 = 70,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 3,
                    Title = "MEN",
                    Author = "Fotih Duman",
                    Description = "Bir odamning o'zini nafsiga qarshi qo'llagan ammalari va choralari haqida",
                    ISBN = "TH4567890032",
                    ListPrice = 32,
                    Price = 10,
                    Price50 = 55,
                    Price100 = 43,
                    CategoryId = 3,
                },
                new Product
                {
                    Id = 4,
                    Title = "Daftar hoshiyasidagi bitiklar",
                    Author = "O'tkir Hoshimov",
                    Description = "Odamlarning fe'l-atvorlari, madaniyatlarini talqin qiluvchi kitob",
                    ISBN = "UJH3456789",
                    ListPrice = 32,
                    Price = 10,
                    Price50 = 67,
                    Price100 = 99,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Author = "Ron Parker",
                    Description = "Rock ismli sayyoh odamning to'lqin vaqtida okeandagi aysbergga urilgan kemada necha kungacha qanday tarzda hayot kechirganini tasvirlovchi kitob",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 6,
                    Title = "Leaves and Wonders",
                    Author = "Laura Phantom",
                    Description = "Bunda g'oliblik va mag'lublikning asosiy sabablari va asoslarini bildiruvchi asar",
                    ISBN = "FOT000000001",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3,
                });
        }
    }
}
