import { Component, OnInit } from "@angular/core";
import { DataService } from "../shared/dataService";
import { FormGroup, FormControl } from "@angular/forms";
import * as _entity from "../shared/entities";
import { log } from "util";

@Component({
  selector: 'pointbuy-app',
  templateUrl: 'pointbuy.component.html',
  styleUrls: ['pointbuy.component.css']
})
export class PointBuyComponent implements OnInit {

  dndRace: _entity.dndRace[];
//  raceTraits: _entity.RaceTrait[] = [];
  raceTraits: string[] = [];
  race: _entity.dndRace;
  languages: string[] = [];

  currentPoints:number = 0 
  pointArray: number[] = [8,8,8,8,8,8]
  midCalculation: number = 0;

  pointBuyForm = new FormGroup({
    race: new FormControl(''),

  })


  constructor(private data: DataService) { }


  ngOnInit(): void {
    this.data.loadRaces()
      .subscribe(success => {
        if (success) {
          this.dndRace = this.data.dndRace

        }
      });
  }


  loadLanguages(name) {
    this.race = this.dndRace.find(x => x.name == name)
    this.languages = [];
    for (let data of this.race.languages) {
      this.languages.push(data.languageName)
    }
    return this.languages
  }

    loadTraits(name) {
      this.race = this.dndRace.find(x => x.name == name)
    this.raceTraits = [];
    for (let data of this.race.raceTrait) {
      this.raceTraits.push(data.traitName)
    }
    return this.raceTraits
  }

  calculatePointBuy(score, type) {
    if (type == "str") { this.pointArray[0] = parseInt(score) }
    if (type == "dex") { this.pointArray[1] = parseInt(score) }
    if (type == "con") { this.pointArray[2] = parseInt(score) }
    if (type == "int") { this.pointArray[3] = parseInt(score) }
    if (type == "wis") { this.pointArray[4] = parseInt(score) }
    if (type == "cha") { this.pointArray[5] = parseInt(score) }
    this.midCalculation = 0;
   

    for (let ability of this.pointArray) {
      if (ability == 14) {
        this.midCalculation += (1 + ability - 8)
      }
      if (ability == 15) {
        this.midCalculation += (2 + ability - 8)
      }
      if (ability < 14) {
        this.midCalculation += (ability - 8)
      }
    }
    this.currentPoints = this.midCalculation
    return this.currentPoints
  }

  onSubmit() {
    this.data.characterRace = this.pointBuyForm.value.race
    this.data.characterRaceAttributes = this.raceTraits
    this.data.characterLanguage = this.languages
  }



}


