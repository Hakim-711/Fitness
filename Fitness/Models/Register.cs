using System.ComponentModel.DataAnnotations;

namespace Fitness.Models
{
    public class Register
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Current Weight is required")]
        public float CurrentWeight { get; set; }

        [Required(ErrorMessage = "Desired Weight is required")]
        public float DesiredWeight { get; set; }

        [Required(ErrorMessage = "Height is required")]
        public string Height { get; set; }

        public string BMI { get; set; }

        [Required(ErrorMessage = "Home Address is required")]
        public string HomeAddress { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Zip Code/Postal is required")]
        public int Code { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select a plan")]
        public string Plan { get; set; }

        public bool Agree { get; set; }
    }
}
