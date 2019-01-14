import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-questionlist',
  templateUrl: './questionlist.component.html',
  styleUrls: ['./questionlist.component.scss']
})
export class QuestionlistComponent implements OnInit {
  questionsList$: Object;

  constructor(private data: DataService) { }

  ngOnInit() {
    this.data.getQuestions().subscribe(
      data => this.questionsList$ = data);
  }

}
