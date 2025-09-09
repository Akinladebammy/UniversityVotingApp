using System.ComponentModel.DataAnnotations;

namespace UniversityVotingApp.Model.Entities
{
    public class Candidate
    {
        [Key]
        public Guid CandidateId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Position { get; set; }  

        [Required]
        public Guid ElectionId { get; set; }
        public Election Election { get; set; }

        public ICollection<Vote> Votes { get; set; }
    }
}
