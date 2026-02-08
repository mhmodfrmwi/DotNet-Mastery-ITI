using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-N5TCAKUS\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Fiction",
                    Description = "Fictional narrative works, including novels and short stories."
                },
                new Category
                {
                    Id = 2,
                    Name = "Technology",
                    Description = "Books related to software, engineering, and modern tech advancements."
                },
                new Category
                {
                    Id = 3,
                    Name = "History",
                    Description = "Books documenting past events, civilizations, and historical figures."
                }
            );

            
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    Name = "J.K. Rowling",
                    userName = "jk_rowling",
                    Email = "jk@example.com",
                    Password = "password123", 
                    Age = 58,
                    Address = "Edinburgh, Scotland, UK",
                    Phone = "+44123456789",
                    Brief = "British author, philanthropist, and film producer, best known for writing the Harry Potter fantasy series."
                },
                new Author
                {
                    Id = 2,
                    Name = "Robert C. Martin",
                    userName = "uncle_bob",
                    Email = "bob@clean-coder.com",
                    Password = "securepass456",
                    Age = 71,
                    Address = "Gurnee, Illinois, USA",
                    Phone = "+19876543210",
                    Brief = "American software engineer and author, also known as Uncle Bob. He is a co-author of the Agile Manifesto."
                }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Harry Potter and the Philosopher's Stone",
                    Brief = "The first novel in the Harry Potter series.",
                    Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.",
                    Price = 250.50m,
                    Quantity = 100,
                    PublishDate = new DateTime(1997, 6, 26),
                    photoSourceString = "D:\\ITI\\data\\C#\\.Net\\LinQ-EF\\EntityFramworkDay2\\WinFormsApp1\\WinFormsApp1\\photos\\12744514_161090037606960_3174452805785756224_n.jpg", 
                    authorId = 1, 
                    categoryId = 1 
                },
                new Book
                {
                    Id = 2,
                    Title = "Clean Code",
                    Brief = "A Handbook of Agile Software Craftsmanship.",
                    Description = "Even bad code can function. But if code isn't clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn't have to be that way. This book looks at the principles and best practices of writing clean, maintainable code.",
                    Price = 650.00m,
                    Quantity = 45,
                    PublishDate = new DateTime(2008, 8, 1),
                    photoSourceString = "D:\\ITI\\data\\C#\\.Net\\LinQ-EF\\EntityFramworkDay2\\WinFormsApp1\\WinFormsApp1\\photos\\cm-punk-tell-me-wallpaper-4k.jpg",
                    authorId = 2, // Matches Robert C. Martin
                    categoryId = 2 // Matches Technology
                },
                new Book
                {
                    Id = 3,
                    Title = "The Clean Coder",
                    Brief = "A Code of Conduct for Professional Programmers.",
                    Description = "Programmers who endure and succeed amidst swirling uncertainty and nonstop pressure share a common attribute: They care about the practice of creating software. They treat it as a craft. They are professionals. In The Clean Coder: A Code of Conduct for Professional Programmers, legendary software expert Robert C. Martin introduces the disciplines, techniques, tools, and practices of true software craftsmanship.",
                    Price = 580.00m,
                    Quantity = 20,
                    PublishDate = new DateTime(2011, 5, 13),
                    photoSourceString = "D:\\ITI\\data\\C#\\.Net\\LinQ-EF\\EntityFramworkDay2\\WinFormsApp1\\WinFormsApp1\\photos\\cm-punk-tell-me-wallpaper-4k.jpg",
                    authorId = 2, // Matches Robert C. Martin
                    categoryId = 2 // Matches Technology
                }
            );
        }
    }
}
