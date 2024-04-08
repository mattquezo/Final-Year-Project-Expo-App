using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCUExpoApp.Models
{
    public class ExpoProject
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string? ProjectTitle { get; set; }
        public string? ProjectSummary { get; set; }
        public string? SupervisorsName { get; set; }
        public StudentProgramme? StudentProgramme { get; set; }
        public string? ProjectLocation { get; set; }
        public virtual ICollection<ProjectArea>? ProjectAreas { get; set; }
        public virtual ICollection<ProjectTechnology>? ProjectTechnologies { get; set; }
        public virtual ICollection<ProjectStudent>? ProjectStudents { get; set; }
    }
}
