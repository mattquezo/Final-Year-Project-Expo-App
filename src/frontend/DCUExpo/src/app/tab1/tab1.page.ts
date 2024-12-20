import { Component, ViewChild } from '@angular/core';
import { ApiHttpService } from '../services/api-http.service';
import { Project } from '../models/project';
import { ProjectService } from '../services/project.service';
import { Router } from '@angular/router';
import { technologies } from '../models/projectTechnologyList';
import { areas } from '../models/projectAreaList';
import { programmes } from '../models/studentProgrammeList';
import { locations } from '../models/projectLocationList';
import { IonAccordionGroup, IonSelect } from '@ionic/angular';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page {

 // refer to the select via the template reference
 @ViewChild('area', { static: false }) area: IonSelect | undefined;
 
 // refer to the select via the template reference
 @ViewChild('technology', { static: false }) technology: IonSelect | undefined;
 
 // refer to the select via the template reference
 @ViewChild('location', { static: false }) location: IonSelect | undefined;
 
 // refer to the select via the template reference
 @ViewChild('programme', { static: false }) programme: IonSelect | undefined;

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

  @ViewChild('accordionGroup', { static: true }) accordionGroup: IonAccordionGroup|undefined;

  // When the app opens, it will load every project and list them
  ionViewWillEnter() {
    if(!this.dataLoaded)
      {
        this.getProject();
      }
  }

  // Toggle function for accordion drop down menu
  toggleAccordion = () => {
    const nativeEl = this.accordionGroup;
    if (nativeEl!.value === 'filter') {
      nativeEl!.value = undefined;
    } else {
      nativeEl!.value = 'filter';
    }
  };

  // Selecting a different filter will reset the previous selected filter
  resetFilter(){
    this.area!.value = "";
    this.location!.value = "";
    this.technology!.value = "";
    this.programme!.value = "";
  }

  // Selecting project will direct user to details tab
  selectProject(item: Project) {
    console.log(item);
    this._projectService.assignProjectId(item.projectId);
    this.router.navigateByUrl('/tabs/tab3');
  }

  // Gets API call for each project
  getProject() {
    this.dataLoaded = false;
    this.spinner.show();
    var url = "http://dcuexpoapp-dev.eba-5gqsqffu.eu-west-1.elasticbeanstalk.com/api/ExpoProject"  // Online database hosted on AWS RDS
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      this.spinner.hide();
      console.log(response);
    },(error) => alert(error.message))
  }

  // Get API call for projects containing filtered technology
  getProjectByTechnology(technology: string) {
    this.resetFilter();
    this.technology!.value = technology;
    this.searchString = technology;
    this.spinner.show();
    this.toggleAccordion();
    console.log(technology);
    this.dataLoaded = false;
    var url = "http://dcuexpoapp-dev.eba-5gqsqffu.eu-west-1.elasticbeanstalk.com/api/ExpoProject/projecttechnology/" + technology
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      this.spinner.hide();
      console.log(response);
    })
  }

  // Get API call for projects containing filtered area
  getProjectByArea(area: string) {
    this.resetFilter();
    this.area!.value = area;
    this.searchString = area;
    this.spinner.show();
    this.toggleAccordion();
    this.dataLoaded = false;
    var url = "http://dcuexpoapp-dev.eba-5gqsqffu.eu-west-1.elasticbeanstalk.com/api/ExpoProject/projectarea/" + area
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      this.spinner.hide();
      console.log(response);
    })
  }

  // Get API call for projects containing filtered student programme
  getProjectByProgramme(programme: string) {
    this.resetFilter();
    this.searchString = programme;
    this.spinner.show();
    this.toggleAccordion();
    this.dataLoaded = false;
    this.programme!.value = programme;
    var url = "http://dcuexpoapp-dev.eba-5gqsqffu.eu-west-1.elasticbeanstalk.com/api/ExpoProject/studentprogramme/" + programme
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      this.spinner.hide();
      console.log(response);
    })
  }

  // Get API call for projects containing filtered location
  getProjectByLocation(location: string) {
    this.resetFilter();
    this.location!.value = location;
    this.searchString = location;
    this.spinner.show();
    this.toggleAccordion();
    this.dataLoaded = false;
    var url = "http://dcuexpoapp-dev.eba-5gqsqffu.eu-west-1.elasticbeanstalk.com/api/ExpoProject/projectlocation/" + location
    this._apiHttpService.get<Project>(url).subscribe((response: any) => {
      this.dataLoaded = true;
      this.data = response
      this.spinner.hide();
      console.log(response);
    })
  }
}
