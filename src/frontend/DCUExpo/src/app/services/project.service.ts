import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  selectedProject : number = -1;
  constructor() { }

  public assignProjectId(id: number) {
    this.selectedProject = id
  }

  public getSelectedProjectId() {
    return this.selectedProject;
  }
}
