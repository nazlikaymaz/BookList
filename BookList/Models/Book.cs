﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BookName { get; set; }
        public string Writer { get; set; }
    }
}
