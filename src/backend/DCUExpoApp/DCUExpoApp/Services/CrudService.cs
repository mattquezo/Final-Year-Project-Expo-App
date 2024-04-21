using DCUExpoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DCUExpoApp.Services
{
    // Crud service
    public class CrudService
    {
        public readonly ExpoContext _expoContext;
        public CrudService(ExpoContext context) {
            _expoContext = context;
        }

        // Gets all projects and puts it into an array
        public List<ExpoProject> GetAllProjects()
        {
            return _expoContext.Projects.ToList();
        }

        // Get a project and all its details
        public ExpoProject GetProject(int id)
        {
            return _expoContext.Projects
                .Include(p => p.ProjectAreas)
                .Include(p => p.StudentProgramme)
                .Include(p => p.ProjectTechnologies)
                .Include(p => p.ProjectStudents)
                .Where(p => p.ProjectId == id).First();
        }

        // Get project by area
        public List<ExpoProject> GetProjectByProjectArea(string projectArea)
        {
            return _expoContext.Projects.Where(p => 
            p.ProjectAreas!.Any(pa => pa.ProjectAreaName == projectArea)).ToList();
        }

        // Get project by technology
        public List<ExpoProject> GetProjectByProjectTechnology(string projectTechnology)
        {
            return _expoContext.Projects.Where(p => 
            p.ProjectTechnologies!.Any(pt => pt.ProjectTechnologyName == projectTechnology)).ToList();
        }

        // Get project by programme
        public List<ExpoProject> GetProjectByStudentProgramme(string studentProgramme)
        {
            return _expoContext.Projects.Where(p => 
            p.StudentProgramme!.StudentProgrammeName! == studentProgramme).ToList();
        }

        // Get project by location
        public List<ExpoProject> GetProjectByProjectLocation(string projectLocation)
        {
            return _expoContext.Projects.Where(p => 
            p.ProjectLocation == projectLocation).ToList();
        }
    }
}
