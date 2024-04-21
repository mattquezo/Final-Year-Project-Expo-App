using DCUExpoApp.Models;
using DCUExpoApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DCUExpoApp.Controllers
{
    // API controller for database
    [Route("api/[controller]")]
    [ApiController]
    public class ExpoProjectController : ControllerBase
    {
        public readonly CrudService _crudService;
        public ExpoProjectController(CrudService crudService) {
            _crudService = crudService; // Crud Service definition
        }

        // Initial project entry data
        private static ExpoProject[] ExpoProjectData = new ExpoProject[]
        {
            new ExpoProject()
            {
                Id = 5,
                ProjectTitle = "Size and Fit Prediction in Fashion E-Commerce",
                ProjectSummary = "The leading cause of product returns is poor size and fit (S&F). The objective of this project was to automate and improve S&F recommendations at the time of purchase. This \"what if\" project combines real-world e-commerce order and returns data with synthesized customer data to build a recommendation system for size and fit. It shows the potential to reduce size-related product returns which is not only beneficial for customers but also can increase profit margins for fashion e-commerce businesses and reduce these businesses' carbon footprint.",
                SupervisorsName = "Prof Alan Smeaton",
                StudentProgramme = new StudentProgramme(){StudentProgrammeName = "Data Science"},
                ProjectAreas = new ProjectArea[]
                {
                    new ProjectArea()
                    {
                        ProjectAreaName = "Artificial Intelligence"
                    }
                },
                ProjectTechnologies = new ProjectTechnology[]
                {
                    new ProjectTechnology()
                    {
                        ProjectTechnologyName = "Python"
                    }
                },
                ProjectStudents = new ProjectStudent[]
                {
                    new ProjectStudent()
                    {
                        StudentId = null,
                        StudentName = "Louise Anderson",
                        StudentEmail = "louise.anderson23@mail.dcu.ie"
                    }
                }

            }
        };

        // GET API call for all projects
        [HttpGet(Name = "GetAllExpoProject")]
        public ExpoProject[] Get()
        {
            return _crudService.GetAllProjects().ToArray();
        }

        // GET API call for project by ID
        [HttpGet("projectid/{id}", Name = "GetExpoProject")]
        public ExpoProject GetId(int id)
        {
            return _crudService.GetProject(id);
        }

        // GET API call for projects by area
        [HttpGet("projectarea/{projectArea}", Name = "GetExpoProjectByProjectArea")]
        public ExpoProject[] GetProjectArea(string projectArea)
        {
            return _crudService.GetProjectByProjectArea(projectArea).ToArray();
        }

        // GET API call for projects by technology
        [HttpGet("projecttechnology/{projectTechnology}", Name = "GetExpoProjectByProjectTechnology")]
        public ExpoProject[] GetProjectTechnology(string projectTechnology)
        {
            return _crudService.GetProjectByProjectTechnology(projectTechnology).ToArray();
        }

        // GET API call for projects by programme
        [HttpGet("studentprogramme/{studentProgramme}", Name = "GetExpoProjectByStudentProgramme")]
        public ExpoProject[] GetStudentProgramme(string studentProgramme)
        {
            return _crudService.GetProjectByStudentProgramme(studentProgramme).ToArray();
        }

        // GET API call for project by location
        [HttpGet("projectlocation/{projectLocation}", Name = "GetExpoProjectByProjectLocation")]
        public ExpoProject[] GetProjectLocation(string projectLocation)
        {
            return _crudService.GetProjectByProjectLocation(projectLocation).ToArray();
        }
    }
}
