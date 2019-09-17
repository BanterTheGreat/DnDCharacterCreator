import { Component } from "@angular/core";
import { Router } from '@angular/router';

@Component({
  selector: 'creator-app',
  templateUrl: 'creator.component.html',

})
export class CreatorComponent{

  constructor(private router: Router) {
    this.router.navigate(['/pointbuy']);

  }

   
}

