import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MapService {

  selectedMap : string = "None";
  mode : string = "Map Select"
  coordinates: any = null;

  constructor() { }

  // Select Map state
  setSelectedMap(newMap: string)
  {
    this.selectedMap = newMap;
  }

  // Sets state of map tab
  setMode(newMode: string)
  {
    this.mode = newMode;
  }

  // Gets the map that was selected
  getSelectedMap(){
    return this.selectedMap;
  }

  // Returns the state of the map tab
  getMode(){
    return this.mode;
  }
}
