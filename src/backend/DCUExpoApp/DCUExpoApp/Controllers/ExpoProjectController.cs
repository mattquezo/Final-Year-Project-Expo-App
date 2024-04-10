using DCUExpoApp.Models;
using DCUExpoApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DCUExpoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpoProjectController : ControllerBase
    {
        public readonly CrudService _crudService;
        public ExpoProjectController(CrudService crudService) {
            _crudService = crudService;
        }

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

        [HttpGet(Name = "GetAllExpoProject")]
        public ExpoProject[] Get()
        {
            return _crudService.GetAllProjects().ToArray();
        }

        [HttpGet("projectid/{id}", Name = "GetExpoProject")]
        public ExpoProject GetId(int id)
        {
            return _crudService.GetProject(id);
        }

        [HttpGet("projectarea/{projectArea}", Name = "GetExpoProjectByProjectArea")]
        public ExpoProject[] GetProjectArea(string projectArea)
        {
            return _crudService.GetProjectByProjectArea(projectArea).ToArray();
        }

        [HttpGet("projecttechnology/{projectTechnology}", Name = "GetExpoProjectByProjectTechnology")]
        public ExpoProject[] GetProjectTechnology(string projectTechnology)
        {
            return _crudService.GetProjectByProjectTechnology(projectTechnology).ToArray();
        }

        [HttpGet("studentprogramme/{studentProgramme}", Name = "GetExpoProjectByStudentProgramme")]
        public ExpoProject[] GetStudentProgramme(string studentProgramme)
        {
            return _crudService.GetProjectByStudentProgramme(studentProgramme).ToArray();
        }

        [HttpGet("projectlocation/{projectLocation}", Name = "GetExpoProjectByProjectLocation")]
        public ExpoProject[] GetProjectLocation(string projectLocation)
        {
            return _crudService.GetProjectByProjectLocation(projectLocation).ToArray();
        }
    }
}
