import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Product } from './shared/Models/porduct';
import { Pagination } from './shared/Models/pagination';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'client';

  constructor(){}

}
