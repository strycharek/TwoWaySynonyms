import { Component, OnInit } from '@angular/core';
import { SynonymService } from '../synonym.service';
import { SynonymListService } from './synonym-list-service';

@Component({
  selector: 'app-synonym-list',
  templateUrl: './synonym-list.component.html',
  styleUrls: ['./synonym-list.component.css']
})
export class SynonymListComponent implements OnInit {

  public synonymsData: Array<any>;

  constructor (private synonymService: SynonymService, private synonymListService:SynonymListService) {
    this.loadDatas();
  }

  ngOnInit() {
    this.synonymListService.change.subscribe(isRefresh => {
      this.loadDatas();
    });
  }

  loadDatas(){
    this.synonymService.get().subscribe((data: any) => this.synonymsData = data);
  }
}
