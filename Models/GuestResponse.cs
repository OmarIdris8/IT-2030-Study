using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{

    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string? Email { get; set; }

       [Required(ErrorMessage = "Please enter your phone number")]
       [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone number is not valid.")]
        public string? Phone { get; set; }


        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
