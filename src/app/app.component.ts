import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { articleModel } from "./models/articleModel";
import { DataService } from "./services/data.service";
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'willdom-test-angular';
  showForm: boolean = false;

  formTitle: string;
  formDescription: string;
  formContent: string;
  formImage: string;
  formUrl: string;  

  dataArticles: articleModel[] = [];
  totalArticles: 0;

  constructor(
    private http: HttpClient,
    public dataService: DataService,
  ) {}

  ngOnInit() {    
    this.getRemote();
  }

  getLocal() {
    this.showForm = true;    
    this.dataArticles = this.dataService.getArticle();    
  }

  getRemote() {
    this.showForm = false;  
    this.http.get('https://gnews.io/api/v4/search?q=watches&token=d1b81696c678f25561fbc947421beaad').subscribe({
      next: (data: any) => {
        this.dataArticles = data.articles;
        this.totalArticles = data.totalArticles;
      },
      error: error => {
        this.dataArticles = [];
        this.totalArticles = 0;
      }    
    });
  }

  getRemotePlus() {
    this.showForm = false;  
    this.http.get('https://localhost:5001/article').subscribe({
      next: (data: any) => {
        this.dataArticles = data;
      },
      error: error => {
          this.dataArticles = [];
      }
    });
  }

  addArticle() {
    let today = formatDate(new Date(), 'yyyy/MM/dd', 'en');
    
    this.dataService.addArticle({
      title: this.formTitle,
      description: this.formDescription,
      content: this.formContent,
      image: this.formImage,
      publishedAt: today.toString(),
      url: this.formUrl,
    });
    this.formTitle = '';
    this.formDescription = '';
    this.formContent = '';
    this.formImage = '';
    this.formUrl = '';
  }

  removeArticle(data) {
    this.dataService.removeArticle(data);
  }
}
