using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DCUExpoApp.Models
{
    public class ProjectStudent
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public int? StudentId { get; set; }
        public string? StudentEmail { get; set; }
    }
}
