import { Component } from '@angular/core';
import { DataService } from '../shared/dataService';

@Component({
  selector: 'summary-app',
  templateUrl: 'summary.component.html',
  styleUrls: ['summary.component.css']
})
export class SummaryComponent {

  constructor(private data: DataService) { }



}
