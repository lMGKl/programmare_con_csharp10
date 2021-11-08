﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFCore_Hello
{
    [Table("Car")]
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string Targa { get; set; }

        [Required]
        public string Modello { get; set; }
        public int? PersonId { get; set; }

        public Person Person { get; set; }
    }

    public record Person
    {
        [Key]
        public int PersonId { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

}
