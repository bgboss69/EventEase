using System.ComponentModel.DataAnnotations;

namespace EventEase.Models{
    public class Attendee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public required string Email { get; set; }
        public int EventId { get; set; }

        public required Event Event { get; set; }
    }
}