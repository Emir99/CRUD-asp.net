using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Building
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Can't be Blank!")]
        [MaxLength(100, ErrorMessage ="Can't be longer than 100!")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "You need to provide a valid email address!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Can't be Blank!")]
        [Display(Name = "Building Type")]
        public Type1 Building_type { get; set; }

        [Required(ErrorMessage = "Can't be Blank!")]
        [Range(0,1000,ErrorMessage = "Must be in range from 0 to 1000!")]
        public int Stories { get; set; }

        public ICollection<Owner> Owners { get; set; }
    }
}
