import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `<app-pessoas></app-pessoas>
             <router-outlet></router-outlet>`
})
export class AppComponent {
  title = 'CrudWeb';
}
