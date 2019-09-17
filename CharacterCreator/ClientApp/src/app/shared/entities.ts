export interface ArmorProf {
  id: number;
  armorProfName: string;
}

export interface WeaponProf {
  id: number;
  weaponProfName: string;
}

export interface ToolProf {
  id: number;
  type: string;
  toolProfName: string;
}

export interface SavingThrow {
  id: number;
  savingThrow: string;
}

export interface AllowedSkill {
  id: number;
  allowedSkill: string;
}

export interface Proficiencies {
  id: number;
  class: string;
  armorProf: ArmorProf[];
  weaponProf: WeaponProf[];
  toolProf: ToolProf[];
  savingThrows: SavingThrow[];
  skillsProfAmount: number;
  allowedSkills: AllowedSkill[];
}

export interface EquipmentChoice {
  id: number;
  class: string;
  choice1: string;
  choice2: string;
}

export interface Ability {
  id: number;
  class: string;
  abilityTitle: string;
  abilityDesc: string;
}

export interface dndClass {
  id: number;
  name: string;
  hitDice: number;
  proficiencies: Proficiencies;
  equipmentChoices: EquipmentChoice[];
  abilities: Ability[];
}

export interface AbilityScoreIncrease {
  id: number;
  ability: string;
  increase: number;
  class: string;
}

export interface RaceTrait {
  id: number;
  race: string;
  traitName: string;
  traitDesc: string;
}

export interface Language {
  id: number;
  languageName: string;
}

export interface dndRace {
  id: number;
  name: string;
  abilityScoreIncrease: AbilityScoreIncrease[];
  raceTrait: RaceTrait[];
  age: string;
  alignment: string;
  size: string;
  speed: string;
  languages: Language[];
}

export interface BackgroundLanguage {
  id: number;
  languageName: string;
}

export interface BackgroundToolProf {
  id: number;
  type: string;
  toolProfName: string;
}

export interface BackgroundItem {
  id: number;
  itemName: string;
}

export interface Background {
  id: number;
  backgroundTitle: string;
  backgroundLanguage: BackgroundLanguage[];
  backgroundAbility: string;
  backgroundToolProf: BackgroundToolProf[];
  backgroundSkill: AllowedSkill[];
  backgroundVarSkill: AllowedSkill[];
  backgroundItem: BackgroundItem[];
}

export interface AbilityScores {
  id: number;
  strength: string;
  dexterity: string;
  constitution: string;
  intelligence: string;
  wisdom: string;
  charisma: string;
}

export interface Character {
  id: number;
  name: string;
  class: dndClass;
  race: dndRace;
  abilityscores: AbilityScores
  background: Background;
  alignment: string;
}
