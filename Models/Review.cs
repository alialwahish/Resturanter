using System.ComponentModel.DataAnnotations;
using System;
namespace Entity
{

    public abstract class BaseEntity { }
    public class Review : BaseEntity
    {
        

        [Key]
        public long Id { get; set; }

        [Required]
        public string Reviewer_Name { get; set; }

        [Required]
        public string Resturant_Name { get; set; }

        [Required]
        [MinLength(10)]
        public string review { get; set; }

        [Required]
        public DateTime Review_Date {get;set;}

        [Required]
        public int Star{get;set;}
        
    }

}