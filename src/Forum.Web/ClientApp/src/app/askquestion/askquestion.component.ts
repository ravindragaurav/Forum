import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';

@Component({
  selector: 'app-askquestion',
  templateUrl: './askquestion.component.html',
  styleUrls: ['./askquestion.component.scss']
})
export class AskquestionComponent implements OnInit {
  questionTitle$ : string
  questionDetails$ : string


  constructor(private data : DataService) { }

  ngOnInit() {
  }

  askQuestion(questionTitle, questionDetails){
    this.questionTitle$ = questionTitle.value();
    alert("question Title is : "+this.questionTitle$ + " and question details is :"+this.questionDetails$ );
    this.data.postQuestion(this.questionTitle$, this.questionDetails$);
  }

}
