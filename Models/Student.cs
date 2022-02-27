using System;
using System.ComponentModel.DataAnnotations;

namespace StudentDb.Models
{
    public class Student
    {
       
        public int StudentId { get; set; }
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Alphabets are allowed in names.")]
        [StringLength(25)]
        public string Name { get; set;}
        [Range(1900, 2022)]
        public string Year { get; set;}
    }
}
