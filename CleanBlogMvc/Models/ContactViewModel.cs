// Models/ContactViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace CleanBlogCoreMvc.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "A name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "An email is required.")]
        [EmailAddress(ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A phone number is required.")]
        [Phone(ErrorMessage = "Phone number is not valid.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "A message is required.")]
        public string Message { get; set; }
    }
}
