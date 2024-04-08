import { Component } from '@angular/core';
import { ApiHttpService } from '../services/api-http.service';
import { Project } from '../models/project';
import { ProjectService } from '../services/project.service';

@Component({
  selector: 'app-tab3',
  templateUrl: 'tab3.page.html',
  styleUrls: ['tab3.page.scss']
})
export class Tab3Page {

  data: Project | undefined;
  searchString: string = "";
  private _apiHttpService: ApiHttpService
  private _projectService: ProjectService
  
  constructor(apiHttpService: ApiHttpService, projectService: ProjectService) {
    this._apiHttpService = apiHttpService
    this._projectService = projectService
  }

  ionViewWillEnter() {
    this.getProject();
  }

  getProject() {
    var selectId = this._projectService.getSelectedProjectId();
    if (selectId > -1) {
      var url = "https://localhost:7025/api/ExpoProject/projectid/" + selectId;
      this._apiHttpService.get<Project>(url).subscribe((response: any) => {
        this.data = response
        console.log(response);
      })
    }
  }
}
