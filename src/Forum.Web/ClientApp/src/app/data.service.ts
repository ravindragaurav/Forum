import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  getUsers(){
   return this.http.get('https://jsonplaceholder.typicode.com/users');
  }

  getUser(userId) {
    return this.http.get('https://jsonplaceholder.typicode.com/users/'+userId)
  }

  getPosts() {
    return this.http.get('https://jsonplaceholder.typicode.com/posts')
  }

  getControllerData() {
    return this.http.get("https://localhost:44358/api/SampleData/WeatherForecasts")
  }

  getQuestions() {
    return this.http.get("https://localhost:44358/forum/getquestions")
  }

  postQuestion(questionTitle, questionDetails) {
    return this.http.get("https://localhost:44358/forum/postquestion?questionTitle=" + questionTitle + "&questionDetails=" + questionDetails)
  }

}
