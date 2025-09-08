using System.ComponentModel.DataAnnotations;

namespace UniversityVotingApp.Model.Entities
{
    public class Election
    {
        [Key]
        public Guid ElectionId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }  

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
