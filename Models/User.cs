using System.ComponentModel.DataAnnotations;

namespace BudDyMeal.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        // "Student" or "StallOwner"
        [Required]
        public string Role { get; set; } = "Student";

        // Optional: links a StallOwner to their specific stall ID later
        public int? StallId { get; set; }
    }
}