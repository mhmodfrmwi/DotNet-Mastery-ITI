using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    photoSourceString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    authorId = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_authorId",
                        column: x => x.authorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Address", "Age", "Brief", "Email", "Name", "Password", "Phone", "userName" },
                values: new object[,]
                {
                    { 1, "Edinburgh, Scotland, UK", 58, "British author, philanthropist, and film producer, best known for writing the Harry Potter fantasy series.", "jk@example.com", "J.K. Rowling", "password123", "+44123456789", "jk_rowling" },
                    { 2, "Gurnee, Illinois, USA", 71, "American software engineer and author, also known as Uncle Bob. He is a co-author of the Agile Manifesto.", "bob@clean-coder.com", "Robert C. Martin", "securepass456", "+19876543210", "uncle_bob" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Fictional narrative works, including novels and short stories.", "Fiction" },
                    { 2, "Books related to software, engineering, and modern tech advancements.", "Technology" },
                    { 3, "Books documenting past events, civilizations, and historical figures.", "History" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Brief", "Description", "Price", "PublishDate", "Quantity", "Title", "authorId", "categoryId", "photoSourceString" },
                values: new object[,]
                {
                    { 1, "The first novel in the Harry Potter series.", "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.", 250.50m, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Harry Potter and the Philosopher's Stone", 1, 1, "D:\\ITI\\data\\C#\\.Net\\LinQ-EF\\EntityFramworkDay2\\WinFormsApp1\\WinFormsApp1\\photos\\12744514_161090037606960_3174452805785756224_n.jpg" },
                    { 2, "A Handbook of Agile Software Craftsmanship.", "Even bad code can function. But if code isn't clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn't have to be that way. This book looks at the principles and best practices of writing clean, maintainable code.", 650.00m, new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Clean Code", 2, 2, "D:\\ITI\\data\\C#\\.Net\\LinQ-EF\\EntityFramworkDay2\\WinFormsApp1\\WinFormsApp1\\photos\\cm-punk-tell-me-wallpaper-4k.jpg" },
                    { 3, "A Code of Conduct for Professional Programmers.", "Programmers who endure and succeed amidst swirling uncertainty and nonstop pressure share a common attribute: They care about the practice of creating software. They treat it as a craft. They are professionals. In The Clean Coder: A Code of Conduct for Professional Programmers, legendary software expert Robert C. Martin introduces the disciplines, techniques, tools, and practices of true software craftsmanship.", 580.00m, new DateTime(2011, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "The Clean Coder", 2, 2, "D:\\ITI\\data\\C#\\.Net\\LinQ-EF\\EntityFramworkDay2\\WinFormsApp1\\WinFormsApp1\\photos\\cm-punk-tell-me-wallpaper-4k.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_authorId",
                table: "Books",
                column: "authorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_categoryId",
                table: "Books",
                column: "categoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
