using System.ComponentModel.DataAnnotations;
using UniversityVotingApp.Model.Enums;

namespace UniversityVotingApp.Model.Entities
{
    public class Election
    {
        [Key]
        public Guid ElectionId { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public ElectionStatus Status { get; set; } = ElectionStatus.Draft;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();
        public ICollection<Vote> Votes { get; set; } = new List<Vote>();
    }
}
