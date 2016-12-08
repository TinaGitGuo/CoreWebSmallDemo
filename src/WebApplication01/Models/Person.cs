using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication01.Models
{
    public class PersonViewModel
    {
        public Person Person { get; set; } = new Person();
    }
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

    }
}
