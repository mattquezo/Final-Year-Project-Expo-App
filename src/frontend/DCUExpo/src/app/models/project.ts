import { StudentProgramme } from "./studentprogramme"
import { ProjectArea } from "./projectarea"
import { ProjectTechnology } from "./projecttechnology"
import { ProjectStudents } from "./projectstudents"

export interface Project {
    id : number
    projectId : number
    projectTitle : string
    projectSummary : string
    supervisorsName : string
    studentProgramme : StudentProgramme
    projectLocation : string
    projectAreas : ProjectArea[]
    projectTechnologies : ProjectTechnology[]
    projectStudents : ProjectStudents[]
}