import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  selectedProject : number = -1;
  constructor() { }

  // Assigning Project ID to a project
  public assignProjectId(id: number) {
    this.selectedProject = id
  }

  // Returns a selected project
  public getSelectedProjectId() {
    return this.selectedProject;
  }
}
