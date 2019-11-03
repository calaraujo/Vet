using System.ComponentModel.DataAnnotations;

namespace Vet.Common.Models
{
    public class EmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}