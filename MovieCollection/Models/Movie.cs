using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Please select movie category.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "Please enter movie title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter movie release year.")]
        public short Year { get; set; }
        [Required(ErrorMessage = "Please enter movie director.")]
        public string Director { get; set; }
        
        [Required(ErrorMessage = "Please select movie rating.")]
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [MaxLength(100, ErrorMessage = "{0} can have a max of {1} characters.")]
        public string Notes { get; set; }
    }
}
