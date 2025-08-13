using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WelcomeWebpage.Models
{
    public class AdminInfo
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = "";

        [EmailAddress, StringLength(150)]
        public string? Email { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

    }

}