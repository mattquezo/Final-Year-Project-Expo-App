import { Component } from '@angular/core';
import { ImageMapCoordinate } from '../image-map/image-map.component';
import { ApiHttpService } from '../services/api-http.service';
import { ProjectService } from '../services/project.service';
import { Router } from '@angular/router';
import { coordinatesL101,coordinatesL125,coordinatesL114,coordinatesL128, 
  coordinatesLG25, coordinatesLG26, coordinatesLG27 } from '../data/imagedata';
import { MapService } from '../services/map.service';
import { NgxSpinnerService } from 'ngx-spinner';

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

  // Spinner will load when selecting a project
  getClick(coordinate: ImageMapCoordinate) {
    this.spinner.show();
    setTimeout(() => {
      this.spinner.hide();
    }, 3000);
    console.log(`Clicked on ${coordinate.name}`)
    this.selectProjectId(coordinate.name!);
  }

  // On start up, Select Map state will load, displaying list of rooms
  ionViewWillEnter() {
    if(this._mapService.getMode() == "Map")
      {
        this.selectedMap = this._mapService.getSelectedMap();
        this.setMode('Map')
        this.coordinates = this._mapService.coordinates;
        this.spinner.hide();
      }
  }


  // Selecting a map will activate spinner for 2 seconds
  selectMap(selectedMap: string){
    this.spinner.show();
    setTimeout(() => {
      this.spinner.hide();
    }, 2000);
    this._mapService.setSelectedMap(selectedMap);
    this.selectedMap = selectedMap;
    this.mode = "Map";
    console.log(selectedMap);

    // Switch case for whichever room was selected
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
    private router: Router, private spinner: NgxSpinnerService) {
    this._apiHttpService = apiHttpService
    this._projectService = projectService
    this._mapService = mapService
  }

  // Sets the state of the map tab
  setMode(mode: string){
    this.mode = mode

    if(mode == 'Map Select'){
      this.selectedMap = 'None'
    }
  }

  // When project is selected, it will redirect to details tab
  selectProjectId(id: string) {
    console.log(id);
    this._projectService.assignProjectId(parseInt(id));
    this._mapService.coordinates = null;
    this.router.navigateByUrl('/tabs/tab3');
  }

}
