using System.ComponentModel.DataAnnotations;

namespace UniversityVotingApp.Model.Entities
{
    public class Admin
    {
        [Key]
        public Guid AdminId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}
