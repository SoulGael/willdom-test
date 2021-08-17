import { Injectable } from '@angular/core';
import { articleModel } from "./../models/articleModel";

@Injectable({
  providedIn: 'root'
})
export class DataService {
  article: articleModel[];

  constructor() { 
    this.article = [];
  }

  getArticle(): articleModel[] {
    if(localStorage.getItem('article') === null) {
      this.article = [];
    }
    else {
      this.article = JSON.parse(localStorage.getItem('article'));
    }
    return this.article;
  }

  addArticle(article: articleModel):void {
    this.article.unshift(article);
    let articles;
    if(localStorage.getItem('article') === null) {
      articles = [];
      articles.unshift(article);
      localStorage.setItem('article', JSON.stringify(articles));
    }
    else {
      articles = JSON.parse(localStorage.getItem('article'));
      articles.unshift(article);
      localStorage.setItem('article', JSON.stringify(articles));
    }
  }

  removeArticle(data: articleModel) {
    const index = this.article.indexOf(data);
    if ( index >= 0 )
    {
        this.article.splice(index, 1);
        localStorage.setItem('article', JSON.stringify(this.article));
    }
  }
}
