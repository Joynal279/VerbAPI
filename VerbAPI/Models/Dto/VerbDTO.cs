using System;
using System.ComponentModel.DataAnnotations;

namespace VerbAPI.Models.Dto
{
	public class VerbDTO
	{
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public int occupancy { get; set; }
        public int Sqft { get; set; }

    }
}

