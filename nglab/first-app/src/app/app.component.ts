import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  hero = 'Howard T. Duck';

  onLike() {
    window.alert(`I like ${this.hero}!`);
  }
}
