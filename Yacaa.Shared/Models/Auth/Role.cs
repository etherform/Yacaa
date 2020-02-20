﻿using System.ComponentModel.DataAnnotations;

namespace Yacaa.Shared.Models.Auth
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int AccessLevel { get; set; }
    }
}