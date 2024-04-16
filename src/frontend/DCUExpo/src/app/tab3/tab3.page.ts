import { Component } from '@angular/core';
import { ApiHttpService } from '../services/api-http.service';
import { Project } from '../models/project';
import { ProjectService } from '../services/project.service';
import { MapService } from '../services/map.service';
import { coordinatesL101,coordinatesL125,coordinatesL114,coordinatesL128, 
  coordinatesLG25, coordinatesLG26, coordinatesLG27 } from '../data/imagedata';
import { Router } from '@angular/router';

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
    private router: Router) {
    this._apiHttpService = apiHttpService
    this._projectService = projectService
    this._mapService = mapService
  }

  selectedId = -1;
  selectedProjectRoom = "";

  ionViewWillEnter() {
    var selectId = this._projectService.getSelectedProjectId();
    this.selectedId = selectId;
    this.getProject();
  }

  showOnMap(){
    this._mapService.setMode("Map");
    this._mapService.setSelectedMap(this.selectedProjectRoom);

    switch (this.selectedProjectRoom){
      case "L101":
        coordinatesL101.forEach(element => {
          if(parseInt(element.name!) == this.selectedId)
            {
              this._mapService.coordinates = [element];
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
    var selectId = this._projectService.getSelectedProjectId();
    this.selectedId = selectId
    if (selectId > -1) {
      var url = "https://localhost:7025/api/ExpoProject/projectid/" + selectId;
      this._apiHttpService.get<Project>(url).subscribe((response: any) => {
        this.data = response
        console.log(response);
        this.selectedProjectRoom = (response.projectLocation);
      })
    }
  }
}
