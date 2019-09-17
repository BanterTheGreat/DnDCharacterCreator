using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{

    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
    }

    public class BackgroundVarSkill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
    }

    public class BackgroundSkill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
    }

    public class ArmorProf
    {
        public int Id { get; set; }
        public string ArmorProfName { get; set; }
    }
    public class WeaponProf
    {
        public int Id { get; set; }
        public string WeaponProfName { get; set; }
    }
    public class ToolProf
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string ToolProfName { get; set; }
    }

    public class Language
    {
        public int Id { get; set; }
        public string LanguageName { get; set; }
    }
    public class Material
    {
        public int Id { get; set; }
        public string MaterialName { get; set; }
    }
    public class AllowedSkills
    {
        public int Id { get; set; }
        public string AllowedSkill { get; set; }
    }

    public class SavingThrows
    {
        public int Id { get; set; }
        public string SavingThrow { get; set; }
    }

    public class AbilityScores
    {
        public int Id { get; set; }
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }
    }
}


