import { Component, OnInit } from '@angular/core';
import { Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-hero',
  templateUrl: './hero.component.html',
  styleUrls: ['./hero.component.css']
})
export class HeroComponent implements OnInit {

  @Input() name: string | undefined;
  @Output() liked = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

}
