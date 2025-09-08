using System.ComponentModel.DataAnnotations;

namespace UniversityVotingApp.Model.Entities
{
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }  

        [Required]
        [MaxLength(50)]
        public string MatricNumber { get; set; } 

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        public string PasswordHash { get; set; }  

        public string FaceEmbedding { get; set; } 

        public double Latitude { get; set; } 
        public double Longitude { get; set; }

        public bool HasVoted { get; set; } = false;  

        public ICollection<Vote> Votes { get; set; }
    }
}
