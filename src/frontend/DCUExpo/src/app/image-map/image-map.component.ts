import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'image-map',
  templateUrl: './image-map.component.html',
  styleUrls: ['./image-map.component.scss']
})

export class ImageMapComponent implements OnInit {

  @Input()
  src: string = ""

  @Input()
  coordinates: ImageMapCoordinate[] | undefined;

  @Input()
  canEdit: boolean = false;

  @Output('onClick')
  onClick: EventEmitter<ImageMapCoordinate> = new EventEmitter();

  constructor() { }

  ngOnInit() { this.onAreaCreate(0,0)  }

  // Definition of coordinates
  getCoordinateStyle(coordinate: ImageMapCoordinate): object {
    return {
      top: `${coordinate.y}%`,
      left: `${coordinate.x}%`,
      height: `${coordinate.height}%`,
      width: `${coordinate.width}%`
    };
  }

  onAreaClick(coordinate: any) {
    this.onClick.emit(coordinate);
  }

  onAreaContext(e: MouseEvent, coordinate: ImageMapCoordinate) {
    if(this.canEdit)
    {
      if(coordinate) {
        console.log('editing')

      }
      else {
        console.log('creating')
      }
    
      e.stopPropagation();
      return false;
    }

    return true;
  }

  onAreaCreate(x: number, y: number): ImageMapCoordinate {
    const coordinate = new ImageMapCoordinate({x, y, width: 100, height: 100});
    return coordinate
  }

  onAreaEdit(coordinate: ImageMapCoordinate): ImageMapCoordinate {
    return coordinate;
  }

}

// Defining the coordinates of a project
export class ImageMapCoordinate {
  x: number = 0  // x coordinate
  y: number = 0  // y coordinate
  width: number = 100 // size of width of box
  height: number = 100  // size of height of box
  name?: string  // Project Number

  constructor(init?: Partial<ImageMapCoordinate>) {
    Object.assign(this, init);
  }
}