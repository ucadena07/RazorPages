using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]
        public int id { get; set; }

        [Required]
        public String Name { get; set; }

        public int Author { get; set; }

        public string ISBN { get; set; }
    }
}
