import { Component, OnInit } from "@angular/core";
import { DataService } from "../shared/dataService";
import * as _entity from "../shared/entities";
import { forEach } from "@angular/router/src/utils/collection";
import { FormGroup, FormControl } from "@angular/forms";

@Component({
  selector: 'class.app',
  templateUrl: 'class.component.html',
  styleUrls: ['class.component.css']
})
export class ClassComponent implements OnInit {

  fakeArray  = new Array()
  dndClass: _entity.dndClass[]
  currentClass: _entity.dndClass;
  equipmentChoices: _entity.EquipmentChoice[];

  
  classAbilities: string[] = [];
  toolProfs: string[] = [];
  weaponProfs: string[] = [];
  allowedSkills: string[] = [];
  skillAmount: number;

  skillsToSend: string[] = [];

  classForm = new FormGroup({
    class: new FormControl(''),
    skill1: new FormControl('Unavailable'),
    skill2: new FormControl('Unavailable'),
    skill3: new FormControl('Unavailable'),
    skill4: new FormControl('Unavailable'),


  })
  
  constructor(private data: DataService) { }

  ngOnInit(): void {
    this.data.loadClasses()
      .subscribe(success => {
        if (success) {
          this.dndClass = this.data.dndClass;

        }
      });
  }

  //loadAbilities(input: string): void {
  //  this.data.loadAbilities(input)
  //    .subscribe(success => {
  //      if (success) {
  //        this.classAbilities = this.data.classAbility;        }
  //    });
  //}

  

  loadAbilities(name) {
    this.currentClass = this.dndClass.find(x => x.name == name)  //Add data from selected class to variable
    this.classAbilities = [];                 // Wipe data before filling.
    for (let data of this.currentClass.abilities) { // For loop.
      this.classAbilities.push(data.abilityTitle) // Add data from entity to variable.
      
    }
    return this.classAbilities
  }

  loadToolProfs(name) {
    this.currentClass = this.dndClass.find(x => x.name == name)  //Add data from selected class to variable
    this.toolProfs = [];
    for (let data of this.currentClass.proficiencies.toolProf) {
      this.toolProfs.push(data.toolProfName)

    }
    return this.toolProfs
  }

  loadWeaponProfs(name) {
    this.currentClass = this.dndClass.find(x => x.name == name)  //Add data from selected class to variable
    this.weaponProfs = [];
    for (let data of this.currentClass.proficiencies.armorProf) {
      this.weaponProfs.push(data.armorProfName)
    }
    for (let data of this.currentClass.proficiencies.weaponProf) {
      this.weaponProfs.push(data.weaponProfName)
    }
    return this.weaponProfs
  }

  loadSkills(name) {
    this.currentClass = this.dndClass.find(x => x.name == name)  //Add data from selected class to variable
    this.allowedSkills = [];
    for (let data of this.currentClass.proficiencies.allowedSkills) {
      this.allowedSkills.push(data.allowedSkill)
    }
    return this.allowedSkills
  }

  loadSkillAmount(name) {
    this.currentClass = this.dndClass.find(x => x.name == name)  //Add data from selected class to variable
    this.skillAmount = 0;
    this.skillAmount += this.currentClass.proficiencies.skillsProfAmount
    this.fakeArray = new Array(this.skillAmount)
    return this.fakeArray
  }

  onSubmit() {
    
    this.data.chosenClass = this.dndClass.find(x => x.name == this.classForm.value.class) // Send selected class


    this.equipmentChoices = [];
    for (let data of this.data.chosenClass.equipmentChoices) { //Process equipment choices
      this.equipmentChoices.push(data)
    }
    this.data.possibleEquipment = this.equipmentChoices //Send equipment choices

    this.data.characterClass = this.classForm.value.class  //Send class
    this.data.characterClassAbilities = this.classAbilities //Send class abilities
    this.skillsToSend.push(this.classForm.value.skill1, this.classForm.value.skill2, this.classForm.value.skill3, this.classForm.value.skill4) // Put all selected skills in a array
    this.data.characterSkills = this.skillsToSend //Send skills


  }


}
