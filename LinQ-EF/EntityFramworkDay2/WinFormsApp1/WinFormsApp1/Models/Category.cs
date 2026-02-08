using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WinFormsApp1.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength ]
        public string Name { get; set; }
        public string Description { get; set; }

        public HashSet<Book> Books { get; set; }= new HashSet<Book>();
    }
}
