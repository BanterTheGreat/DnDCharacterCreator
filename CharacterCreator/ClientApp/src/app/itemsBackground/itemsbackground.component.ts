import { Component, OnInit } from "@angular/core";
import { DataService } from "../shared/dataService";
import * as _entity from "../shared/entities";
import { FormGroup, FormControl } from "@angular/forms";

@Component({
  selector: 'items-app',
  templateUrl: 'itemsbackground.component.html',
  styleUrls: ['itemsbackground.component.css']

})
export class ItemsBackgroundComponent implements OnInit  {


  backgrounds: _entity.Background[];
  currentBackground: _entity.Background;

  languages: string[] = []
  tools: string[] = []
  skills: string[] = [];
  items: string[] = [];

  chosenLanguages: string[] = []
  chosenTools: string[] = []
  chosenSkills: string[] = []
  chosenItems: string[] = []

  constructor(private data: DataService) {}




  backgroundForm = new FormGroup({
    background: new FormControl(''),
    language1: new FormControl('Unavailable'),
    language2: new FormControl('Unavailable'),
    tool1: new FormControl('Unavailable'),
    tool2: new FormControl('Unavailable'),
    skill1: new FormControl('Unavailable'),
    skill2: new FormControl('Unavailable'),
    equip1: new FormControl('Unavailable'),
    equip2: new FormControl('Unavailable'),
    equip3: new FormControl('Unavailable'),
    equip4: new FormControl('Unavailable'),





  })

  ngOnInit(): void {
    this.data.loadBackgrounds()
      .subscribe(success => {
        if (success) {
          this.backgrounds = this.data.background

        }
      });

    
  }

  loadLanguage(title) {
    this.currentBackground = this.backgrounds.find(x => x.backgroundTitle == title)
    this.languages = [];
    for (let data of this.currentBackground.backgroundLanguage) {
      this.languages.push(data.languageName)
    }
    return this.languages
  }

  loadTools(title) {
    this.currentBackground = this.backgrounds.find(x => x.backgroundTitle == title)
    this.tools = [];
    for (let data of this.currentBackground.backgroundToolProf) {
      this.tools.push(data.toolProfName)
    }
    return this.tools
  }

  loadSkills(title) {
    this.currentBackground = this.backgrounds.find(x => x.backgroundTitle == title)
    this.skills = [];
    for (let data of this.currentBackground.backgroundSkill) {
      this.skills.push(data.allowedSkill)
    }
    return this.skills
  }

  loadItems(title) {
    this.currentBackground = this.backgrounds.find(x => x.backgroundTitle == title)
    this.items = [];
    for (let data of this.currentBackground.backgroundItem) {
      this.items.push(data.itemName)
    }
    return this.items
  }

  onSubmit() {
    this.data.characterBackground = this.backgroundForm.value.background;
    this.data.characterSkills.push(this.backgroundForm.value.skill1, this.backgroundForm.value.skill2)
    this.data.characterEquipment.push(this.backgroundForm.value.equip1, this.backgroundForm.value.equip2, this.backgroundForm.value.equip3, this.backgroundForm.value.equip4)
    for (let data of this.items) {
      this.data.characterEquipment.push(data)
    }
    this.data.characterTools.push(this.backgroundForm.value.tool1, this.backgroundForm.value.tool2)
    this.data.characterLanguage.push(this.backgroundForm.value.language1, this.backgroundForm.value.language2)
    this.data.removeEmpty()


  }

}

