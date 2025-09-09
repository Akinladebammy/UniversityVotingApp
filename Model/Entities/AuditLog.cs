using System.ComponentModel.DataAnnotations;
using UniversityVotingApp.Model.Enums;

namespace UniversityVotingApp.Model.Entities
{
    public class AuditLog
    {
        [Key]
        public Guid AuditLogId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public AuditAction Action { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
