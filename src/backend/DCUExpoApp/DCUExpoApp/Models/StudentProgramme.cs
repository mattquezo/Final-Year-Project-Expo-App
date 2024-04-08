using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCUExpoApp.Models
{
    public class StudentProgramme
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentProgrammeId { get; set; }
        public string? StudentProgrammeName { get; set; }
    }
}
