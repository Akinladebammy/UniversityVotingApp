using System.ComponentModel.DataAnnotations;

namespace UniversityVotingApp.Model.Entities
{
    public class Auditor
    {
        [Key]
        public Guid AuditorId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}
