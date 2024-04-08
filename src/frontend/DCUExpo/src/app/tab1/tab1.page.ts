import { Component } from '@angular/core';
import { ApiHttpService } from '../services/api-http.service';
import { Project } from '../models/project';
import { ProjectService } from '../services/project.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page {

  data : any;
  searchString : string = "";
  private _apiHttpService : ApiHttpService
  private _projectService : ProjectService
  
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
    this.getProject();
  }

  selectProject(item: Project){
    console.log(item);
    this._projectService.assignProjectId(item.projectId);
    this.router.navigateByUrl('/tabs/tab3');
  }

  getProject() {
    var url = "https://localhost:7025/api/ExpoProject"
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.data = response
      console.log(response);
    })
  }
}
