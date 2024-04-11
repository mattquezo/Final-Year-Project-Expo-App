import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MapService {

  selectedMap : string = "None";
  mode : string = "Map Select"

  constructor() { }

  setSelectedMap(newMap: string)
  {
    this.selectedMap = newMap;
  }

  setMode(newMode: string)
  {
    this.mode = newMode;
  }

  getSelectedMap(){
    return this.selectedMap;
  }

  getMode(){
    return this.mode;
  }
}
