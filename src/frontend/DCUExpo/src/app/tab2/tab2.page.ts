import { Component } from '@angular/core';
import { ImageMapCoordinate } from '../image-map/image-map.component';
import { ApiHttpService } from '../services/api-http.service';
import { ProjectService } from '../services/project.service';
import { Router } from '@angular/router';
import { Project } from '../models/project';
import { coordinatesL101,coordinatesL125,coordinatesL114,coordinatesL128, 
  coordinatesLG25, coordinatesLG26, coordinatesLG27 } from '../data/imagedata';
import { MapService } from '../services/map.service';
import { map } from 'rxjs';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page {

  image: string = '../assets/rooms/L101.png'
  coordinates: ImageMapCoordinate[] = coordinatesL101;

  selectedMap: string = "None";
  mode: string = "Map Select";

  showImage: boolean = true;
  private _apiHttpService: ApiHttpService;
  private _projectService: ProjectService;
  private _mapService: MapService;

  getClick(coordinate: ImageMapCoordinate) {
    console.log(`Clicked on ${coordinate.name}`)
    this.selectProjectId(coordinate.name!);
  }

  selectMap(selectedMap: string){
    this._mapService.setSelectedMap(selectedMap);
    this.selectedMap = selectedMap;
    this.mode = "Map";
    console.log(selectedMap);
    switch (selectedMap){
      case "L101":
        this.coordinates = coordinatesL101;
        break;
      case "L114":
        this.coordinates = coordinatesL114;
        break;
      case "L125":
        this.coordinates = coordinatesL125;
        break;
      case "L128":
        this.coordinates = coordinatesL128;
        break;
      case "LG25":
        this.coordinates = coordinatesLG25;
        break;
      case "LG26":
        this.coordinates = coordinatesLG26;
        break;
      case "LG27":
        this.coordinates = coordinatesLG27;
        break;
    }

    console.log(this.coordinates);

  }

  constructor(apiHttpService : ApiHttpService, projectService : ProjectService, mapService: MapService,
    private router: Router) {
    this._apiHttpService = apiHttpService
    this._projectService = projectService
    this._mapService = mapService
  }

  setMode(mode: string){
    this.mode = mode

    if(mode == 'Map Select'){
      this.selectedMap = 'None'
    }
  }

  selectProjectId(id: string) {
    console.log(id);
    this._projectService.assignProjectId(parseInt(id));
    this.router.navigateByUrl('/tabs/tab3');
  }

}
