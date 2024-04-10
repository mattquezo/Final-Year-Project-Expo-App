import { Component } from '@angular/core';
import { ApiHttpService } from '../services/api-http.service';
import { Project } from '../models/project';
import { ProjectService } from '../services/project.service';
import { Router } from '@angular/router';
import { technologies } from '../models/projectTechnologyList';
import { areas } from '../models/projectAreaList';
import { programmes } from '../models/studentProgrammeList';
import { locations } from '../models/projectLocationList';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page {

  data : any;
  dataLoaded: boolean = false;
  technologiesList : any = technologies;
  areasList : any = areas;
  programmesList : any = programmes;
  locationsList : any = locations;
  searchString : string = "";
  private _apiHttpService : ApiHttpService;
  private _projectService : ProjectService;
  
  constructor(apiHttpService : ApiHttpService, projectService : ProjectService,
    private router: Router) {
    this._apiHttpService = apiHttpService
    this._projectService = projectService
  }

  // handleSearch() {
  //   var url = "https://localhost:7025/api/ExpoProject/projectarea/" + this.searchString
  //   this._apiHttpService.get<Project[]>(url).subscribe((response: any) => {
  //     this.data = response;
  //     console.log(response);
  //   })
  // }

  ionViewWillEnter() {
    //this.getProject();
  }

  selectProject(item: Project) {
    console.log(item);
    this._projectService.assignProjectId(item.projectId);
    this.router.navigateByUrl('/tabs/tab3');
  }

  getProject() {
    this.dataLoaded = false;
    var url = "https://localhost:7025/api/ExpoProject"
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      console.log(response);
    })
  }

  getProjectByTechnology(technology: string) {
    console.log(technology);
    this.dataLoaded = false;
    var url = "https://localhost:7025/api/ExpoProject/projecttechnology/" + technology
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      console.log(response);
    })
  }

  getProjectByArea(area: string) {
    this.dataLoaded = false;
    var url = "https://localhost:7025/api/ExpoProject/projectarea/" + area
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      console.log(response);
    })
  }

  getProjectByProgramme(programme: string) {
    this.dataLoaded = false;
    var url = "https://localhost:7025/api/ExpoProject/studentprogramme/" + programme
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      console.log(response);
    })
  }

  getProjectByLocation(location: string) {
    this.dataLoaded = false;
    var url = "https://localhost:7025/api/ExpoProject/projectlocation/" + location
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      console.log(response);
    })
  }
}
