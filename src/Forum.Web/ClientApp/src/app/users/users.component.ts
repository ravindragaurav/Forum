import { Component, OnInit } from '@angular/core';
import { DataService} from '../data.service';
import { Observable} from 'rxjs'; //wut is dis?

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})

export class UsersComponent implements OnInit {

 users$: Object;


  constructor(private data:DataService) { }

  ngOnInit() { //one of several angular lifecycle hooks, code executed when component loads
    this.data.getUsers().subscribe(
      data => this.users$ = data
    )
  }

}
