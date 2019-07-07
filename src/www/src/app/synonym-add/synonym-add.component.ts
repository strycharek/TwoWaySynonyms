import { Component, OnInit, Input } from '@angular/core';
import { SynonymService } from '../synonym.service';
import { SynonymListService } from '../synonym-list/synonym-list-service';

@Component({
  selector: 'app-synonym-add',
  templateUrl: './synonym-add.component.html',
  styleUrls: ['./synonym-add.component.css']
})
export class SynonymAddComponent implements OnInit {

  @Input() term:string="";
  @Input() synonyms:string="";
  constructor(private synonymService: SynonymService,private synonymListService:SynonymListService) { }

  ngOnInit() {
  }

  public addRecord = function() {
    this.synonymService.add({
      term:this.term,
      synonyms:this.synonyms
    }).subscribe(
      () => {},
      (err) => {
        console.log(err);
        alert("Error, check console");
      },
      () => {
        alert("Success");
        this.synonymListService.refresh();
      }
    );
  };
}
