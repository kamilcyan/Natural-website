import { Component, OnInit } from '@angular/core';
import { Article } from 'src/app/models/article.model';
import { MainPageService } from 'src/app/services/main-page.service';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent implements OnInit {

  articles: Article[] = [];


  constructor(private mainPageService: MainPageService) { }

  ngOnInit(): void {
    this.mainPageService.getArticles()
      .subscribe({
        next: (articles) => {
          this.articles = articles;
        }
      })
  }
}
