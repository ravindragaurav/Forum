import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DataService } from '../data.service';

@Component({
  selector: 'app-askquestion',
  templateUrl: './askquestion.component.html',
  styleUrls: ['./askquestion.component.scss']
})
export class AskquestionComponent implements OnInit {
  questionTitle$ : string
  questionDetails$ : string
  model: any = {};


  constructor(private data : DataService) { }

  ngOnInit() {
  }

  askQuestion(){
    
    alert("question Title is : "+this.model.questionTitle + " and question details is :"+this.model.questionDetails );
    this.data.postQuestion(this.model.questionTitle, this.model.questionTitle).subscribe();
  }

}
