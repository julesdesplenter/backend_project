using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Invitor.Model
{
    public class Person : IdentityUser
    {
    

        [Required]
        public int Age { get; set; }

        [Required]
        public string Name { get; set; }

       
    }
}
