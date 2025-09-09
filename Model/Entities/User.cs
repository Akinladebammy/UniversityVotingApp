using System.ComponentModel.DataAnnotations;
using UniversityVotingApp.Model.Enums;

namespace UniversityVotingApp.Model.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } 

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public string? FaceEmbedding { get; set; } // For students

        public double? Latitude { get; set; }  // For students
        public double? Longitude { get; set; } // For students

        [Required]
        public UserRole Role { get; set; }  // Student, Admin, Auditor

        // For Students only
        public bool HasVoted { get; set; } = false;

        public ICollection<Vote> Votes { get; set; }
    }
}
