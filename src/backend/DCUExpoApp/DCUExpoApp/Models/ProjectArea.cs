using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCUExpoApp.Models
{
    [Index(nameof(ProjectAreaName))]
    public class ProjectArea
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectAreaId { get; set; }
        public string? ProjectAreaName { get; set; }
    }
}
