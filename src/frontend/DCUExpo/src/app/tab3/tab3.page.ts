import { Component } from '@angular/core';
import { ApiHttpService } from '../services/api-http.service';
import { Project } from '../models/project';
import { ProjectService } from '../services/project.service';
import { MapService } from '../services/map.service';
import { coordinatesL101,coordinatesL125,coordinatesL114,coordinatesL128, 
  coordinatesLG25, coordinatesLG26, coordinatesLG27 } from '../data/imagedata';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';

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
  private _mapService: MapService
  
  constructor(apiHttpService: ApiHttpService, projectService: ProjectService, mapService: MapService, 
    private router: Router, private spinner: NgxSpinnerService) {
    this._apiHttpService = apiHttpService
    this._projectService = projectService
    this._mapService = mapService
  }

  // No project selected state
  selectedId = -1;
  selectedProjectRoom = "";

  // On startup, if selectedID is -1, display warning, else if a project is selected, display project details
  ionViewWillEnter() {
    var selectId = this._projectService.getSelectedProjectId();
    this.selectedId = selectId;
    this.getProject();
  }

  // Map button which highlights the location of a project on its map
  showOnMap(){
    this._mapService.setMode("Map");
    this._mapService.setSelectedMap(this.selectedProjectRoom);

    switch (this.selectedProjectRoom){
      case "L101":
        coordinatesL101.forEach(element => {
          if(parseInt(element.name!) == this.selectedId)  // loop through projects in L101
            {
              this._mapService.coordinates = [element];  // if it matches the project's, highlight it on the map
            } 
        });
        break;
      case "L114":
       coordinatesL114.forEach(element => {
          if(parseInt(element.name!) == this.selectedId)
            {
              this._mapService.coordinates = [element];
            } 
        });
        break;
      case "L125":
        coordinatesL125.forEach(element => {
          if(parseInt(element.name!) == this.selectedId)
            {
              this._mapService.coordinates = [element];
            } 
        });;
        break;
      case "L128":
        coordinatesL128.forEach(element => {
          if(parseInt(element.name!) == this.selectedId)
            {
              this._mapService.coordinates = [element];
            } 
        });;
        break;
      case "LG25":
        coordinatesLG25.forEach(element => {
          if(parseInt(element.name!) == this.selectedId)
            {
              this._mapService.coordinates = [element];
            } 
        });;
        break;
      case "LG26":
        coordinatesLG26.forEach(element => {
          if(parseInt(element.name!) == this.selectedId)
            {
              this._mapService.coordinates = [element];
            } 
        });;
        break;
      case "LG27":
        coordinatesLG27.forEach(element => {
          if(parseInt(element.name!) == this.selectedId)
            {
              this._mapService.coordinates = [element];
            } 
        });;
        break;
    }

    this.router.navigateByUrl('/tabs/tab2');
  }

  getProject() {
    this.spinner.show();
    var selectId = this._projectService.getSelectedProjectId();
    this.selectedId = selectId
    if (selectId > -1) {
      var url = "http://dcuexpoapp-dev.eba-5gqsqffu.eu-west-1.elasticbeanstalk.com/api/ExpoProject/projectid/" + selectId;
      this._apiHttpService.get<Project>(url).subscribe((response: any) => {
        this.data = response
        console.log(response);
        this.selectedProjectRoom = (response.projectLocation);
        this.spinner.hide();
      })
    }
    else
    {
      this.spinner.hide();
    }
  }
}
