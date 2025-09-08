using System.ComponentModel.DataAnnotations;

namespace UniversityVotingApp.Model.Entities
{
    public class Vote
    {
        [Key]
        public Guid VoteId { get; set; }

        [Required]
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        [Required]
        public Guid CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        [Required]
        public Guid ElectionId { get; set; }
        public Election Election { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [Required]
        public string EncryptedVote { get; set; }  // AES-256 encrypted data

        [Required]
        public string VoteReceiptHash { get; set; } // SHA-256 proof
    }
}
