using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WinFormsApp1.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Brief { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string photoSourceString { get; set; }
        public int authorId { get; set; }

        [ForeignKey("authorId")]
        public Author Author { get; set; }

        public int categoryId { get; set; }

        [ForeignKey("categoryId")]
        public Category Category { get; set; }
    }
}
