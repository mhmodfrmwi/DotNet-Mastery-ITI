using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WinFormsApp1.Models
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public int Age { get; set; }
        public string Brief { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public HashSet<Book> Books { get; set; }= new HashSet<Book>();
    }
}
