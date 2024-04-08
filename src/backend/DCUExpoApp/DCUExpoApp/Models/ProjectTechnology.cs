using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCUExpoApp.Models
{
    public class ProjectTechnology
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectTechnologyId { get; set; }
        public string? ProjectTechnologyName { get; set; }
    }
}
