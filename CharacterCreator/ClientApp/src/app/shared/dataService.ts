import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import * as _entity from "./entities";
import { Observable } from "rxjs/Observable";
import { tap, map } from 'rxjs/operators';

@Injectable()
export class DataService {
  constructor(private http: HttpClient) {

  }
   
  public dndClass: _entity.dndClass[]
  public classAbility: _entity.Ability[]
  public dndRace: _entity.dndRace[]
  public raceTrait: _entity.RaceTrait[]
  public background: _entity.Background[]

  public possibleEquipment: _entity.EquipmentChoice[];

  public chosenClass: _entity.dndClass

  public characterRace: string;
  public characterRaceAttributes: string[];
  public characterClass: string;
  public characterClassAbilities: string[];
  public characterSkills: string[];
  public characterTools: string[] = [];
  public characterEquipment: string[] = [];
  public characterBackground: string;
  public characterLanguage: string[] = [];








  loadRaces(): Observable<boolean> {
    return this.http.get("/api/entity/GetAllRaces")
      .pipe(
        map((data: any[]) => {
          this.dndRace = data;
          return true;
        }))
  }

  loadClasses(): Observable<boolean> {
    return this.http.get("/api/entity/GetAllClasses")
      .pipe(
        map((data: any[]) => {
          this.dndClass = data;
          return true;
        }))
  }

  loadBackgrounds(): Observable<boolean> {
    return this.http.get("/api/entity/GetAllBackgrounds")
      .pipe(
        map((data: any[]) => {
          this.background = data;
    return true
  }))
  }

  removeEmpty() {
    this.characterSkills = this.characterSkills.filter(o => o !== 'Unavailable')
    this.characterEquipment = this.characterEquipment.filter(o => o !== 'Unavailable')
    this.characterTools = this.characterTools.filter(o => o !== 'Unavailable')
    this.characterLanguage = this.characterLanguage.filter(o => o !== 'Unavailable')

  }




}
