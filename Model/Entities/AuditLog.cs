using System.ComponentModel.DataAnnotations;

namespace UniversityVotingApp.Model.Entities
{
    public class AuditLog
    {
        [Key]
        public Guid LogId { get; set; }

        [Required]
        public string Action { get; set; }  

        [Required]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [Required]
        public string Actor { get; set; }  

        public string Details { get; set; }  
    }
}
