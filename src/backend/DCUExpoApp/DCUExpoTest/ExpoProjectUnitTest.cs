using DCUExpoApp.Models;
using DCUExpoApp.Services;
using EntityFrameworkMock;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace DCUExpoTest
{
    public class Tests
    {
        private static Mock<DbSet<ExpoProject>> GetMockExpoProject()
        {
            ExpoProject[] expoProject;

            // 10 sample projects for testing
            expoProject = new ExpoProject[]
            {
                new ExpoProject
                {
                    Id = 1,
                    ProjectId = 5,
                    ProjectTitle = "Size and Fit Prediction in Fashion E-Commerce",
                    ProjectSummary = "The leading cause of product returns is poor size and fit (S&F). The objective of this project was to automate and improve S&F recommendations at the time of purchase. This \"what if\" project combines real-world e-commerce order and returns data with synthesized customer data to build a recommendation system for size and fit. It shows the potential to reduce size-related product returns which is not only beneficial for customers but also can increase profit margins for fashion e-commerce businesses and reduce these businesses' carbon footprint.",
                    ProjectLocation = "LG25",
                    SupervisorsName = "Prof Alan Smeaton",

                    ProjectAreas = new ProjectArea[]
                    {
                        new ProjectArea
                        {
                            ProjectAreaId = 1,
                            ProjectAreaName = "Artificial Intelligence"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 2,
                            ProjectAreaName = "Data Analytics"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 3,
                            ProjectAreaName = "E-Commerce"
                        }
                    },

                    ProjectTechnologies = new ProjectTechnology[]
                    {
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 1,
                            ProjectTechnologyName = "Python"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 2,
                            ProjectTechnologyName = "Machine Learning"
                        }
                    },

                    ProjectStudents = new ProjectStudent[]
                    {
                        new ProjectStudent
                        {
                            Id = 1,
                            StudentName = "Louise Anderson",
                            StudentEmail = "louise.anderson23@mail.dcu.ie"
                        }
                    },

                    StudentProgramme = new StudentProgramme()
                    {
                        StudentProgrammeId = 1,
                        StudentProgrammeName = "Data Science"
                    }
                },

                new ExpoProject
                {
                    Id = 5,
                    ProjectId = 88,
                    ProjectTitle = "CrypTic",
                    ProjectSummary = "This is a web-application that scrapes data mainly from Reddit and Facebook so we can sentiment data about mainly Bitcoin so our users can see what other users of those platforms are saying. We are also developing a model using time series to predict the prices of Bitcoin.",
                    ProjectLocation = "L128",
                    SupervisorsName = "Dr Geoff Hamilton",

                    ProjectAreas = new ProjectArea[]
                    {
                        new ProjectArea
                        {
                            ProjectAreaId = 170,
                            ProjectAreaName = "Gaming"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 171,
                            ProjectAreaName = "Software Development"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 172,
                            ProjectAreaName = "Game Engines"
                        }
                    },

                    ProjectTechnologies = new ProjectTechnology[]
                    {
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 172,
                            ProjectTechnologyName = "CSS"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 173,
                            ProjectTechnologyName = "Excel--VB"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 174,
                            ProjectTechnologyName = "HTML5"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 175,
                            ProjectTechnologyName = "JavaScript"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 176,
                            ProjectTechnologyName = "MySQL"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 177,
                            ProjectTechnologyName = "Nodejs"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 178,
                            ProjectTechnologyName = "Python"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 179,
                            ProjectTechnologyName = "React.js"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 180,
                            ProjectTechnologyName = "Machine Learning"
                        }
                    },

                    ProjectStudents = new ProjectStudent[]
                    {
                        new ProjectStudent
                        {
                            Id = 1490,
                            StudentName = "Suhyb Mohammed",
                            StudentEmail = "suhyb.mohammed4@mail.dcu.ie"
                        }
                    },

                    StudentProgramme = new StudentProgramme()
                    {
                        StudentProgrammeId = 2,
                        StudentProgrammeName = "Computer Applications"
                    }
                },

                new ExpoProject
                {
                    Id = 129,
                    ProjectId = 160,
                    ProjectTitle = "The Adoption of the Fiber Laser Irradiation in the Surface Hardness Enhancement of Medium Carbon Steel Alloy",
                    ProjectSummary = "The project investigates how changes in laser beam power and scanning speed affect the microstructure and surface hardness of medium carbon steel alloy (MCSA) samples. Improving the mechanical properties of this commonly used material enables its ability to withstand harsh operating conditions, resulting in prolonged service life and enhanced performance. Laser surface hardening on MCSA has become increasingly in demand to meet the industry's need for high-quality surfaces due to the process's advancement and benefits over traditional heat treating.",
                    ProjectLocation = "L114",
                    SupervisorsName = "Dr Muhannad Obeidi",

                    ProjectAreas = new ProjectArea[]
                    {
                        new ProjectArea
                        {
                            ProjectAreaId = 564,
                            ProjectAreaName = "Mechanical Engineering -- Cooling"
                        }
                    },

                    ProjectTechnologies = new ProjectTechnology[]
                    {
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 557,
                            ProjectTechnologyName = "Laser Technology"
                        }
                    },

                    ProjectStudents = new ProjectStudent[]
                    {
                        new ProjectStudent
                        {
                            Id = 1639,
                            StudentName = "Janella Depakakibo",
                            StudentEmail = "janella.depakakibo2@mail.dcu.ie"
                        }
                    },

                    StudentProgramme = new StudentProgramme()
                    {
                        StudentProgrammeId = 5,
                        StudentProgrammeName = "Mechanical and Manufacturing Engineering (Year 5)"
                    }
                },

                new ExpoProject
                {
                    Id = 84,
                    ProjectId = 60,
                    ProjectTitle = "Smart Commute",
                    ProjectSummary = "Smart Commute is an android app that was developed to provide an easy and simple user experience with a centralised system and a user-friendly interface. Users can use the app to find a cost-effective route using public transport through the app's many features, including route navigation, Real-time information, a Leap card reward scheme, and a guide section for tourists. \n\n",
                    ProjectLocation = "LG27",
                    SupervisorsName = "Dr Stephen Blott",

                    ProjectAreas = new ProjectArea[]
                    {
                        new ProjectArea
                        {
                            ProjectAreaId = 386,
                            ProjectAreaName = "Android"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 387,
                            ProjectAreaName = "GPS--GIS"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 388,
                            ProjectAreaName = "Mobile App"
                        }
                    },

                    ProjectTechnologies = new ProjectTechnology[]
                    {
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 452,
                            ProjectTechnologyName = "CSS"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 453,
                            ProjectTechnologyName = "HTML5"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 454,
                            ProjectTechnologyName = "JavaScript"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 455,
                            ProjectTechnologyName = "MySQL"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 456,
                            ProjectTechnologyName = "Python"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 457,
                            ProjectTechnologyName = "Django"
                        }
                    },

                    ProjectStudents = new ProjectStudent[]
                    {
                        new ProjectStudent
                        {
                            Id = 1586,
                            StudentName = "Caolan Reilly",
                            StudentEmail = "caolan.reilly67@mail.dcu.ie"
                        },
                        new ProjectStudent
                        {
                            Id = 1587,
                            StudentName = "Woranut Sheila Roche Pinket",
                            StudentEmail = "woranut.rochepinket2@mail.dcu.ie"
                        }
                    },

                    StudentProgramme = new StudentProgramme()
                    {
                        StudentProgrammeId = 3,
                        StudentProgrammeName = "Enterprise Computing"
                    }
                },

                new ExpoProject
                {
                    Id = 166,
                    ProjectId = 173,
                    ProjectTitle = "Printing of Magnesium Nanoparticles for Paper Biomedical Sensors",
                    ProjectSummary = "This project investigates the printing of magnesium nanoparticles and their application for biomedical sensors. Magnesium nanoparticles have several useful properties including stability, absorptivity, and thermal and electrical conductivity that allow for their wide range of applications including sensing. An ink stamping method was used to directly deposit these NPs onto a paper substrate for use as sensing for acetone. Human breathe analysis offers a non-invasive, cheap, and rapid method for detecting various volatile organic compounds like acetone for patients with diabetes. ",
                    ProjectLocation = "L101",
                    SupervisorsName = "Prof Dermot Brabazon and Dr Anesu Nyabadza",

                    ProjectAreas = new ProjectArea[]
                    {
                        new ProjectArea
                        {
                            ProjectAreaId = 700,
                            ProjectAreaName = "Additive Manufacturing"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 701,
                            ProjectAreaName = "Advanced Material Engineering"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 702,
                            ProjectAreaName = "Biomedical Engineering"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 703,
                            ProjectAreaName = "Mechanical Design and Manufacture"
                        }
                    },

                    ProjectTechnologies = new ProjectTechnology[]
                    {
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 630,
                            ProjectTechnologyName = "Sensors"
                        }
                    },

                    ProjectStudents = new ProjectStudent[]
                    {
                        new ProjectStudent
                        {
                            Id = 1676,
                            StudentName = "James Okoye",
                            StudentEmail = "james.okoye2@mail.dcu.ie"
                        }
                    },

                    StudentProgramme = new StudentProgramme()
                    {
                        StudentProgrammeId = 7,
                        StudentProgrammeName = "Biomedical Engineering (Year 4)"
                    }
                },

                new ExpoProject
                {
                    Id = 39,
                    ProjectId = 101,
                    ProjectTitle = "StoreB",
                    ProjectSummary = "This application, StoreB, is an android mobile application that allows users to speed up their shopping, save money and provide information concerning store products. The purpose of StoreB is to help users save money and time by providing them with quick and easily accessible information about items they have scanned. The application allows users to create a shopping list beforehand and a budget tracker. The option to create a group shopping basket and budget will also be available. There is also a recommendation system that recommends products based on what the user has in their basket.",
                    ProjectLocation = "L128",
                    SupervisorsName = "Prof Mark Roantree",

                    ProjectAreas = new ProjectArea[]
                    {
                        new ProjectArea
                        {
                            ProjectAreaId =  187,
                            ProjectAreaName = "Gaming"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 188,
                            ProjectAreaName = "Software Development"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 189,
                            ProjectAreaName = "Web Application"
                        }
                    },

                    ProjectTechnologies = new ProjectTechnology[]
                    {
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 198,
                            ProjectTechnologyName = "Java"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 199,
                            ProjectTechnologyName = "MySQL"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 200,
                            ProjectTechnologyName = "Python"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 201,
                            ProjectTechnologyName = "SQL"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 202,
                            ProjectTechnologyName = "XML"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 203,
                            ProjectTechnologyName = "Machine Learning"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 204,
                            ProjectTechnologyName = "Flask"
                        }
                    },

                    ProjectStudents = new ProjectStudent[]
                    {
                        new ProjectStudent
                        {
                            Id = 1497,
                            StudentName = "Isaac Makinde",
                            StudentEmail = "isaac.makinde3@mail.dcu.ie"
                        },
                        new ProjectStudent
                        {
                            Id = 1498,
                            StudentName = "Noah Ajayi",
                            StudentEmail = "noah.ajayi2@mail.dcu.ie"
                        }
                    },

                    StudentProgramme = new StudentProgramme()
                    {
                        StudentProgrammeId = 2,
                        StudentProgrammeName = "Computer Applications"
                    }
                },

                new ExpoProject
                {
                    Id = 130,
                    ProjectId = 144,
                    ProjectTitle = "The Potential for Hydrogen Ramjet Engines in Aviation",
                    ProjectSummary = "This project investigates the potential for hydrogen powered ramjet engines as a method of carbon neutral aviation. The project is focused specifically on the propulsion system. A mathematical model was developed of a ramjet engine. A small-scale ramjet, based off the model, was designed and built. Tests on hydrogen which measured thrust, pressures, and temperatures throughout the ramjet aided in validation of the mathematical model so that it could be used to simulate engines on much larger aircraft.",
                    ProjectLocation = "L114",
                    SupervisorsName = "Dr James Carton",

                    ProjectAreas = new ProjectArea[]
                    {
                        new ProjectArea
                        {
                            ProjectAreaId = 565,
                            ProjectAreaName = "Advanced Material Engineering"
                        }
                    },

                    ProjectTechnologies = new ProjectTechnology[]
                    {
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 558,
                            ProjectTechnologyName = "C--C++"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 559,
                            ProjectTechnologyName = "Soldiworks"
                        }
                    },

                    ProjectStudents = new ProjectStudent[]
                    {
                        new ProjectStudent
                        {
                            Id = 1640,
                            StudentName = "Ciaran Smith",
                            StudentEmail = "ciaran.smith74@mail.dcu.ie"
                        }
                    },

                    StudentProgramme = new StudentProgramme()
                    {
                        StudentProgrammeId = 5,
                        StudentProgrammeName = "Mechanical and Manufacturing Engineering (Year 5)"
                    }
                },

                new ExpoProject
                {
                    Id = 159,
                    ProjectId = 127,
                    ProjectTitle = "Finite Element Analysis on Callus Formation during Bone Fracture Healing",
                    ProjectSummary = "The project recreates a bone fracture model based on previous work to gain validity. The model consists of a 2D section of a long bone that has a transverse fracture and shows each of the healing phases - inflammation, reparation and remodelling. The thesis requires the use of SolidWorks to create the model, Ansys Workbench to model the finite element principles and examine certain parameters. Once validity is established, the model is modified to enable a 4-point-bending test and deformation, and strain in the x and y-axis are examined. The results concur with other research and support that load-bearing treatment is beneficial in the reparation and remodelling phases as this is when the callus is hardened, enabling it to withstand the force of the load.",
                    ProjectLocation = "L125",
                    SupervisorsName = "Dr Bryan MacDonald",

                    ProjectAreas = new ProjectArea[]
                    {
                        new ProjectArea
                        {
                            ProjectAreaId = 682,
                            ProjectAreaName = "Biomedical Engineering"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 683,
                            ProjectAreaName = "Tissue Engineering"
                        }
                    },

                    ProjectTechnologies = new ProjectTechnology[]
                    {
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 617,
                            ProjectTechnologyName = "ANSYS Workbench"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 618,
                            ProjectTechnologyName = "Solidworks"
                        }
                    },

                    ProjectStudents = new ProjectStudent[]
                    {
                        new ProjectStudent
                        {
                            Id = 1669,
                            StudentName = "Danail Tsanov",
                            StudentEmail = "danail.tsanov2@mail.dcu.ie"
                        }
                    },

                    StudentProgramme = new StudentProgramme()
                    {
                        StudentProgrammeId = 7,
                        StudentProgrammeName = "Biomedical Engineering (Year 4)"
                    }
                },

                new ExpoProject
                {
                    Id = 79,
                    ProjectId = 136,
                    ProjectTitle = "Style of You",
                    ProjectSummary = "Style of You is a fashion-based social media app. It was developed to unite a community of like-minded people and create a safe space to share and inspire. Users can post pictures of their clothing and where they got them, linking the website for other users. Users can interact with posts, connect with people in specific style subgenres, and send messages to one another. We want to create a safe environment for all and build a welcoming, positive fashion community. ",
                    ProjectLocation = "L125",
                    SupervisorsName = "Dr Hyowon Lee",

                    ProjectAreas = new ProjectArea[]
                    {
                        new ProjectArea
                        {
                            ProjectAreaId = 376,
                            ProjectAreaName = "Social Networking"
                        }
                    },

                    ProjectTechnologies = new ProjectTechnology[]
                    {
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 435,
                            ProjectTechnologyName = "CSS"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 436,
                            ProjectTechnologyName = "HTML5"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 437,
                            ProjectTechnologyName = "JavaScript"
                        },
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 438,
                            ProjectTechnologyName = "Python"
                        }
                    },

                    ProjectStudents = new ProjectStudent[]
                    {
                        new ProjectStudent
                        {
                            Id = 1576,
                            StudentName = "Mary Josephine Mulready",
                            StudentEmail = "mary.mulready2@mail.dcu.ie"
                        },
                        new ProjectStudent
                        {
                            Id = 1577,
                            StudentName = "Melania Balazs",
                            StudentEmail = "melania.balazs2@mail.dcu.ie"
                        }
                    },

                    StudentProgramme = new StudentProgramme()
                    {
                        StudentProgrammeId = 3,
                        StudentProgrammeName = "Enterprise Computing"
                    }
                },

                new ExpoProject
                {
                    Id = 203,
                    ProjectId = 171,
                    ProjectTitle = "Air Aware - Wearables for Sensing Personal Exposure to Air Pollution",
                    ProjectSummary = "The aim of this project was to develop a reliable, wearable air quality sensor. The device designed is low-cost and low-power and provides the user with a clear understanding of their surrounding air quality. A selection of low-cost sensors have been investigated and eventually refined to develop an air quality system using Arduino technology. The system uses Bluetooth communication to provide users with relevant data relating to their surrounding emissions.",
                    ProjectLocation = "L114",
                    SupervisorsName = "Dr Shirley Coyle",

                    ProjectAreas = new ProjectArea[]
                    {
                        new ProjectArea
                        {
                            ProjectAreaId = 848,
                            ProjectAreaName = "3-D Modelling"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 849,
                            ProjectAreaName = "Arduino"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 850,
                            ProjectAreaName = "Circuit Modeling"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 851,
                            ProjectAreaName = "Device Design"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 852,
                            ProjectAreaName = "Sensor Data"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 853,
                            ProjectAreaName = "Sensor Technology"
                        },
                        new ProjectArea
                        {
                            ProjectAreaId = 854,
                            ProjectAreaName = "Wearable Technology"
                        }
                    },

                    ProjectTechnologies = new ProjectTechnology[]
                    {
                        new ProjectTechnology
                        {
                            ProjectTechnologyId = 719,
                            ProjectTechnologyName = "C--C++"
                        }
                    },

                    ProjectStudents = new ProjectStudent[]
                    {
                        new ProjectStudent
                        {
                            Id = 1714,
                            StudentName = "Níamh Grady",
                            StudentEmail = "niamh.grady3@mail.dcu.ie"
                        }
                    },

                    StudentProgramme = new StudentProgramme()
                    {
                        StudentProgrammeId = 9,
                        StudentProgrammeName = "Electronic and Computer Engineering"
                    }
                }
            };

            // Put the projects into an array
            var data = expoProject.ToList();

            var mockExpoProjectsDbSet = new Mock<DbSet<ExpoProject>>();  // Define mock ExpoProjectDbSet
            mockExpoProjectsDbSet.As<IQueryable<ExpoProject>>().Setup(m => m.Provider).Returns(data.AsQueryable().Provider);
            mockExpoProjectsDbSet.As<IQueryable<ExpoProject>>().Setup(m => m.Expression).Returns(data.AsQueryable().Expression);
            mockExpoProjectsDbSet.As<IQueryable<ExpoProject>>().Setup(m => m.ElementType).Returns(data.AsQueryable().ElementType);
            mockExpoProjectsDbSet.As<IQueryable<ExpoProject>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            mockExpoProjectsDbSet.Setup(m => m.Add(It.IsAny<ExpoProject>())).Callback<ExpoProject>(data.Add);
            return mockExpoProjectsDbSet;

        }

        public CrudService GetMockCrudService()
        {
            var mockExpoDbSet = GetMockExpoProject();

            // Creating a mock ExpoContext (DbContext)
            var mockContext = new Mock<ExpoContext>();

            // Setup the mock context to use data from above, this makes a fake database
            mockContext.Setup(m => m.Projects).Returns(mockExpoDbSet.Object);

            // Create a mockCrudService
            var crudService = new CrudService(mockContext.Object);

            return crudService;
        }

        // Get all projects test
        [Test]
        public void GetProjectCountTest()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetAllProjects();

            Assert.AreEqual(10, results.Count);
        }

        // Get project by ID tests
        [Test]
        public void GetProjectByIdTest1()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProject(88);

            Assert.AreEqual(88, results.ProjectId);
            Assert.AreEqual("CrypTic", results.ProjectTitle);
            Assert.AreEqual("L128", results.ProjectLocation);
            Assert.AreEqual("Dr Geoff Hamilton", results.SupervisorsName);
        }

        [Test]
        public void GetProjectByIdTest2()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProject(127);

            Assert.AreEqual(127, results.ProjectId);
            Assert.AreEqual("Finite Element Analysis on Callus Formation during Bone Fracture Healing", results.ProjectTitle);
            Assert.AreEqual("L125", results.ProjectLocation);
            Assert.AreEqual("Dr Bryan MacDonald", results.SupervisorsName);
        }

        [Test]
        public void GetProjectByIdTest3()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProject(171);

            Assert.AreEqual(171, results.ProjectId);
            Assert.AreEqual("Air Aware - Wearables for Sensing Personal Exposure to Air Pollution", results.ProjectTitle);
            Assert.AreEqual("L114", results.ProjectLocation);
            Assert.AreEqual("Dr Shirley Coyle", results.SupervisorsName);
        }

        // Get project by area test
        [Test]
        public void GetProjectByAreaTest1()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByProjectArea("Artificial Intelligence");

            Assert.True(results.Any(project => project.ProjectId == 5));
            Assert.True(results.Any(project => project.ProjectTitle == "Size and Fit Prediction in Fashion E-Commerce"));
            Assert.True(results.Any(project => project.ProjectLocation == "LG25"));
            Assert.True(results.Any(project => project.SupervisorsName == "Prof Alan Smeaton"));
        }

        [Test]
        public void GetProjectByAreaTest2()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByProjectArea("Biomedical Engineering");

            Assert.True(results.Any(project => project.ProjectId == 173));
            Assert.True(results.Any(project => project.ProjectTitle == "Printing of Magnesium Nanoparticles for Paper Biomedical Sensors"));
            Assert.True(results.Any(project => project.ProjectLocation == "L101"));
            Assert.True(results.Any(project => project.SupervisorsName == "Prof Dermot Brabazon and Dr Anesu Nyabadza"));
        }

        [Test]
        public void GetProjectByAreaTest3()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByProjectArea("Mechanical Engineering -- Cooling");

            Assert.True(results.Any(project => project.ProjectId == 160));
            Assert.True(results.Any(project => project.ProjectTitle == "The Adoption of the Fiber Laser Irradiation in the Surface Hardness Enhancement of Medium Carbon Steel Alloy"));
            Assert.True(results.Any(project => project.ProjectLocation == "L114"));
            Assert.True(results.Any(project => project.SupervisorsName == "Dr Muhannad Obeidi"));
        }

        // Get project by technology test
        [Test]
        public void GetProjectByTechnology1()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByProjectTechnology("Python");

            Assert.True(results.Any(project => project.ProjectId == 60));
            Assert.True(results.Any(project => project.ProjectTitle == "Smart Commute"));
            Assert.True(results.Any(project => project.ProjectLocation == "LG27"));
            Assert.True(results.Any(project => project.SupervisorsName == "Dr Stephen Blott"));
        }

        [Test]
        public void GetProjectByTechnology2()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByProjectTechnology("JavaScript");

            Assert.True(results.Any(project => project.ProjectId == 136));
            Assert.True(results.Any(project => project.ProjectTitle == "Style of You"));
            Assert.True(results.Any(project => project.ProjectLocation == "L125"));
            Assert.True(results.Any(project => project.SupervisorsName == "Dr Hyowon Lee"));
        }

        [Test]
        public void GetProjectByTechnology3()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByProjectTechnology("Java");

            Assert.True(results.Any(project => project.ProjectId == 101));
            Assert.True(results.Any(project => project.ProjectTitle == "StoreB"));
            Assert.True(results.Any(project => project.ProjectLocation == "L128"));
            Assert.True(results.Any(project => project.SupervisorsName == "Prof Mark Roantree"));
        }

        // Get project by programme test
        [Test]
        public void GetProjectByProgramme1()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByStudentProgramme("Computer Applications");

            Assert.True(results.Any(project => project.ProjectId == 88));
            Assert.True(results.Any(project => project.ProjectTitle == "CrypTic"));
            Assert.True(results.Any(project => project.ProjectLocation == "L128"));
            Assert.True(results.Any(project => project.SupervisorsName == "Dr Geoff Hamilton"));
        }

        [Test]
        public void GetProjectByProgramme2()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByStudentProgramme("Electronic and Computer Engineering");

            Assert.True(results.Any(project => project.ProjectId == 171));
            Assert.True(results.Any(project => project.ProjectTitle == "Air Aware - Wearables for Sensing Personal Exposure to Air Pollution"));
            Assert.True(results.Any(project => project.ProjectLocation == "L114"));
            Assert.True(results.Any(project => project.SupervisorsName == "Dr Shirley Coyle"));
        }

        [Test]
        public void GetProjectByProgramme3()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByStudentProgramme("Enterprise Computing");

            Assert.True(results.Any(project => project.ProjectId == 60));
            Assert.True(results.Any(project => project.ProjectTitle == "Smart Commute"));
            Assert.True(results.Any(project => project.ProjectLocation == "LG27"));
            Assert.True(results.Any(project => project.SupervisorsName == "Dr Stephen Blott"));
        }

        // Get project by location test
        [Test]
        public void GetProjectByLocationTest1()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByProjectLocation("LG25");

            Assert.True(results.Any(project => project.ProjectId == 5));
            Assert.True(results.Any(project => project.ProjectTitle == "Size and Fit Prediction in Fashion E-Commerce"));
            Assert.True(results.Any(project => project.ProjectLocation == "LG25"));
            Assert.True(results.Any(project => project.SupervisorsName == "Prof Alan Smeaton"));
        }

        [Test]
        public void GetProjectByLocationTest2()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByProjectLocation("L128");

            Assert.True(results.Any(project => project.ProjectId == 101));
            Assert.True(results.Any(project => project.ProjectTitle == "StoreB"));
            Assert.True(results.Any(project => project.ProjectLocation == "L128"));
            Assert.True(results.Any(project => project.SupervisorsName == "Prof Mark Roantree"));
        }

        [Test]
        public void GetProjectBytLocationTest3()
        {
            var crudService = GetMockCrudService();

            var results = crudService.GetProjectByProjectLocation("LG27");

            Assert.True(results.Any(project => project.ProjectId == 60));
            Assert.True(results.Any(project => project.ProjectTitle == "Smart Commute"));
            Assert.True(results.Any(project => project.ProjectLocation == "LG27"));
            Assert.True(results.Any(project => project.SupervisorsName == "Dr Stephen Blott")); 
        }
    }
}