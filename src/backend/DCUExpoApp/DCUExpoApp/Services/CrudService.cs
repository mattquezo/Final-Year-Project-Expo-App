using DCUExpoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DCUExpoApp.Services
{
    public class CrudService
    {
        public readonly ExpoContext _expoContext;
        public CrudService(ExpoContext context) {
            _expoContext = context;
        }

        public List<ExpoProject> GetAllProjects()
        {
            return _expoContext.Projects
                .Include(p => p.ProjectAreas)
                .Include(p => p.StudentProgramme)
                .Include(p => p.ProjectTechnologies)
                .Include(p => p.ProjectStudents)
                .ToList();
        }

        public ExpoProject GetProject(int id)
        {
            return _expoContext.Projects
                .Include(p => p.ProjectAreas)
                .Include(p => p.StudentProgramme)
                .Include(p => p.ProjectTechnologies)
                .Include(p => p.ProjectStudents)
                .Where(p => p.ProjectId == id).First();
        }

        public List<ExpoProject> GetProjectByProjectArea(string projectArea)
        {
            return _expoContext.Projects
                .Include(p => p.ProjectAreas)
                .Include(p => p.StudentProgramme)
                .Include(p => p.ProjectTechnologies)
                .Include(p => p.ProjectStudents)
                .Where(p => p.ProjectAreas!.Any(pa => pa.ProjectAreaName == projectArea)).ToList();
        }

        public List<ExpoProject> GetProjectByProjectTechnology(string projectTechnology)
        {
            return _expoContext.Projects
                .Include(p => p.ProjectAreas)
                .Include(p => p.StudentProgramme)
                .Include(p => p.ProjectTechnologies)
                .Include(p => p.ProjectStudents)
                .Where(p => p.ProjectTechnologies!.Any(pt => pt.ProjectTechnologyName == projectTechnology)).ToList();
        }

        public List<ExpoProject> GetProjectByStudentProgramme(string studentProgramme)
        {
            return _expoContext.Projects
                .Include(p => p.ProjectAreas)
                .Include(p => p.StudentProgramme)
                .Include(p => p.ProjectTechnologies)
                .Include(p => p.ProjectStudents)
                .Where(p => p.StudentProgramme!.StudentProgrammeName! == studentProgramme).ToList();
        }

        public List<ExpoProject> GetProjectByProjectLocation(string projectLocation)
        {
            return _expoContext.Projects
                .Include(p => p.ProjectAreas)
                .Include(p => p.StudentProgramme)
                .Include(p => p.ProjectTechnologies)
                .Include(p => p.ProjectStudents)
                .Where(p => p.ProjectLocation == projectLocation).ToList();
        }
    }
}
