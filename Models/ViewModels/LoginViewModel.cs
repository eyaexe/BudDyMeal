using System.ComponentModel.DataAnnotations;

namespace BudDyMeal.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        // Tracks which button/tab was clicked: "Student" or "StallOwner"
        public string LoginType { get; set; } = "Student";
    }
}