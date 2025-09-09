using System.ComponentModel.DataAnnotations;

namespace UniversityVotingApp.Model.Entities
{
    public class Vote
    {
        [Key]
        public Guid VoteId { get; set; }

        [Required]
        public Guid UserId { get; set; }  // Student voter
        public User User { get; set; }

        [Required]
        public Guid CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        [Required]
        public Guid ElectionId { get; set; }
        public Election Election { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [Required]
        public string EncryptedVote { get; set; }

        [Required]
        public string VoteReceiptHash { get; set; }
    }
}
