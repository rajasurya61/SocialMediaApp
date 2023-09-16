﻿using System.ComponentModel.DataAnnotations;

namespace SocialMediaApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        // Add more properties as needed
    }
}
