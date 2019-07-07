import { Injectable, Output, EventEmitter } from '@angular/core'

@Injectable()
export class SynonymListService {
  @Output() change: EventEmitter<boolean> = new EventEmitter();

  public refresh() {
    this.change.emit(true);
  }

}
