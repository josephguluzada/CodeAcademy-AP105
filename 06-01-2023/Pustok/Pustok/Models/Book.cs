﻿using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }

        [StringLength(maximumLength:30,ErrorMessage ="Maximum uzunluq 30 ola biler!")]
        public string Name { get; set; }
        public double CostPrice { get; set; } // 50
        public double SalePrice { get; set; } // 100
        public double DiscountPrice { get; set; } // 5% -> 95
        [StringLength(maximumLength: 10, ErrorMessage = "Maximum uzunluq 10 ola biler!")]
        public string Code { get; set; }
        [StringLength(maximumLength: 250, ErrorMessage = "Maximum uzunluq 250 ola biler!")]
        public string Desc { get; set; }
        public bool IsAvailable { get; set; }

        public Author? Author { get; set; }
        public Genre? Genre { get; set; }
    }
}
