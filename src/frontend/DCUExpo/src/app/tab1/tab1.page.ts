import { Component, ViewChild } from '@angular/core';
import { ApiHttpService } from '../services/api-http.service';
import { Project } from '../models/project';
import { ProjectService } from '../services/project.service';
import { Router } from '@angular/router';
import { technologies } from '../models/projectTechnologyList';
import { areas } from '../models/projectAreaList';
import { programmes } from '../models/studentProgrammeList';
import { locations } from '../models/projectLocationList';
import { IonAccordionGroup } from '@ionic/angular';
import { NgxSpinnerService } from 'ngx-spinner';

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
    private router: Router,
    private spinner: NgxSpinnerService) {
    this._apiHttpService = apiHttpService
    this._projectService = projectService
  }

  @ViewChild('accordionGroup', { static: true }) accordionGroup: IonAccordionGroup;

  // handleSearch() {
  //   var url = "https://localhost:7025/api/ExpoProject/projectarea/" + this.searchString
  //   this._apiHttpService.get<Project[]>(url).subscribe((response: any) => {
  //     this.data = response;
  //     console.log(response);
  //   })
  // }

  ionViewWillEnter() {
    if(!this.dataLoaded)
      {
        this.getProject();
      }
  }

  toggleAccordion = () => {
    const nativeEl = this.accordionGroup;
    if (nativeEl.value === 'filter') {
      nativeEl.value = undefined;
    } else {
      nativeEl.value = 'filter';
    }
  };

  selectProject(item: Project) {
    console.log(item);
    this._projectService.assignProjectId(item.projectId);
    this.router.navigateByUrl('/tabs/tab3');
  }

  getProject() {
    this.dataLoaded = false;
    this.spinner.show();
    var url = "https://localhost:7025/api/ExpoProject"
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      this.spinner.hide();
      console.log(response);
    })
  }

  getProjectByTechnology(technology: string) {
    this.spinner.show();
    this.toggleAccordion();
    console.log(technology);
    this.dataLoaded = false;
    var url = "https://localhost:7025/api/ExpoProject/projecttechnology/" + technology
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      this.spinner.hide();
      console.log(response);
    })
  }

  getProjectByArea(area: string) {
    this.spinner.show();
    this.toggleAccordion();
    this.dataLoaded = false;
    var url = "https://localhost:7025/api/ExpoProject/projectarea/" + area
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      this.spinner.hide();
      console.log(response);
    })
  }

  getProjectByProgramme(programme: string) {
    this.spinner.show();
    this.toggleAccordion();
    this.dataLoaded = false;
    var url = "https://localhost:7025/api/ExpoProject/studentprogramme/" + programme
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      this.spinner.hide();
      console.log(response);
    })
  }

  getProjectByLocation(location: string) {
    this.spinner.show();
    this.toggleAccordion();
    this.dataLoaded = false;
    var url = "https://localhost:7025/api/ExpoProject/projectlocation/" + location
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      this.spinner.hide();
      console.log(response);
    })
  }
}
