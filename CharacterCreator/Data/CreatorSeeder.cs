using CharacterCreator.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data
{
    public class CreatorSeeder
    {

        private readonly CreatorContext _ctx;
        private readonly IHostingEnvironment _hosting;
        public CreatorSeeder(CreatorContext context, IHostingEnvironment hosting)
        {
            _ctx = context;
            _hosting = hosting;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();
            // Seed elke kleine entiteit

            //Testing Only, Haalt alles weg voordat hij alles weer inlaadt. 
            _ctx.Abilities.RemoveRange(_ctx.Abilities);
            _ctx.ArmorProfs.RemoveRange(_ctx.ArmorProfs);
            _ctx.WeaponProfs.RemoveRange(_ctx.WeaponProfs);
            _ctx.ToolProfs.RemoveRange(_ctx.ToolProfs);
            _ctx.Items.RemoveRange(_ctx.Items);
            _ctx.BackgroundSkills.RemoveRange(_ctx.BackgroundSkills);
            _ctx.BackgroundVarSkills.RemoveRange(_ctx.BackgroundVarSkills);
            _ctx.AllowedSkills.RemoveRange(_ctx.AllowedSkills);
            _ctx.SavingThrows.RemoveRange(_ctx.SavingThrows);
            _ctx.Languages.RemoveRange(_ctx.Languages);
            _ctx.AbilityIncreases.RemoveRange(_ctx.AbilityIncreases);
            _ctx.EquipmentChoices.RemoveRange(_ctx.EquipmentChoices);
            _ctx.RaceTraits.RemoveRange(_ctx.RaceTraits);
            _ctx.Backgrounds.RemoveRange(_ctx.Backgrounds);
            _ctx.Proficiencies.RemoveRange(_ctx.Proficiencies);
            _ctx.Classes.RemoveRange(_ctx.Classes);
            _ctx.Races.RemoveRange(_ctx.Races);
            _ctx.SaveChanges();
            
            

            if (!_ctx.Languages.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/Language.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<Language>>(json);
                _ctx.Languages.AddRange(data);
                

            }
            if (!_ctx.ArmorProfs.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/ArmorProf.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<ArmorProf>>(json);
                _ctx.ArmorProfs.AddRange(data);
                
                

            };
            if (!_ctx.ToolProfs.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/ToolProf.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<ToolProf>>(json);
                _ctx.ToolProfs.AddRange(data);
                

            };
            if (!_ctx.WeaponProfs.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/WeaponProf.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<WeaponProf>>(json);
                _ctx.WeaponProfs.AddRange(data);


            };
            if (!_ctx.Items.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/Item.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<Item>>(json);
                _ctx.Items.AddRange(data);
                

            };
            if (!_ctx.BackgroundVarSkills.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/WeaponProf.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<BackgroundVarSkill>>(json);
                _ctx.BackgroundVarSkills.AddRange(data);
                

            };
            if (!_ctx.BackgroundSkills.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/BackgroundSkill.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<BackgroundSkill>>(json);
                _ctx.BackgroundSkills.AddRange(data);
                

            };
            //if (!_ctx.Materials.Any())
            //{
            //    var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/Material.json");
            //    var json = File.ReadAllText(filepath);
            //    var data = JsonConvert.DeserializeObject<IEnumerable<Material>>(json);
            //    _ctx.Materials.AddRange(data);
            //};

            if (!_ctx.AllowedSkills.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/AllowedSkills.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<AllowedSkills>>(json);
                _ctx.AllowedSkills.AddRange(data);
                

            };

            if (!_ctx.EquipmentChoices.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/EquipmentChoice.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<EquipmentChoice>>(json);
                _ctx.EquipmentChoices.AddRange(data);


            };
            if (!_ctx.SavingThrows.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/SavingThrows.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<SavingThrows>>(json);
                _ctx.SavingThrows.AddRange(data);
                

            };
            //if (!_ctx.AbilityScores.Any())
            //{
            //    var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/AbilityScores.json");
            //    var json = File.ReadAllText(filepath);
            //    var data = JsonConvert.DeserializeObject<IEnumerable<AbilityScores>>(json);
            //    _ctx.AbilityScores.AddRange(data);


            //};


            if (!_ctx.AbilityIncreases.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/AbilityIncrease.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<AbilityIncrease>>(json);
                _ctx.AbilityIncreases.AddRange(data);


            };


            if (!_ctx.Abilities.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/Abilities.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<Abilities>>(json);
                _ctx.Abilities.AddRange(data);


            };

            if (!_ctx.RaceTraits.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/RaceTrait.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<RaceTrait>>(json);
                _ctx.RaceTraits.AddRange(data);
            }

            if (!_ctx.Races.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/Race.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<Race>>(json);
                _ctx.Races.AddRange(data);
                _ctx.SaveChanges();



                var race = _ctx.Races.Where(r => r.Name == "Human").FirstOrDefault();
                
                var racetraits = _ctx.RaceTraits.Where(r => r.Race == "Human").ToList();
                var abilities = _ctx.AbilityIncreases.Where(a => a.Race == "Human").ToList();
                var languages = _ctx.Languages.Where(a => a.LanguageName == "Common"
                | a.LanguageName == "Elvish"
                | a.LanguageName == "Dwarvish")
                    .ToList();
                race.AbilityScoreIncrease = abilities;
                race.Languages = languages;
                race.RaceTrait = racetraits;
            };

            if (!_ctx.Proficiencies.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/Proficiencies.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<Proficiencies>>(json);
                _ctx.Proficiencies.AddRange(data);
                _ctx.SaveChanges();

                var proficiency = _ctx.Proficiencies.Where(p => p.Class == "Fighter").FirstOrDefault();
                var armorprof = _ctx.ArmorProfs.Where(a => a.ArmorProfName == "All light"
                | a.ArmorProfName == "All medium"
                | a.ArmorProfName == "All heavy").ToList();
                var weaponprof = _ctx.WeaponProfs.Where(w => w.WeaponProfName == "All simple weapons"
                | w.WeaponProfName == "All martial weapons").ToList();
                var toolprof = _ctx.ToolProfs.Where(t => t.ToolProfName == "None").ToList();
                var savingthrows = _ctx.SavingThrows.Where(t => t.SavingThrow == "Strength"
                | t.SavingThrow == "Constitution").ToList();
                var allowedskills = _ctx.AllowedSkills.Where(t => t.AllowedSkill == "Acrobatics"
                | t.AllowedSkill == "Animal Handling"
                | t.AllowedSkill == "Athletics"
                | t.AllowedSkill == "History"
                | t.AllowedSkill == "Insight"
                | t.AllowedSkill == "Intimidation"
                | t.AllowedSkill == "Perception"
                | t.AllowedSkill == "Survival").ToList();

                proficiency.ArmorProf = armorprof;
                proficiency.WeaponProf = weaponprof;
                proficiency.ToolProf = toolprof;
                proficiency.SavingThrows = savingthrows;
                proficiency.AllowedSkills = allowedskills;
                _ctx.SaveChanges();

            };

            if (!_ctx.Classes.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/Class.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<Class>>(json);
                _ctx.Classes.AddRange(data);
                _ctx.SaveChanges();

                var dndclass = _ctx.Classes.Where(c => c.Name == "Fighter").FirstOrDefault();

                var proficiency = _ctx.Proficiencies.Where(p => p.Class == "Fighter").FirstOrDefault();
                var equipchoices = _ctx.EquipmentChoices.Where(p => p.Class == "Fighter").ToList();

                var abilities = _ctx.Abilities.Where(a => a.Class == "Fighter").ToList();

                dndclass.Proficiencies = proficiency;
                dndclass.EquipmentChoices = equipchoices;
                dndclass.Abilities = abilities;


            };

            if (!_ctx.Backgrounds.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/Seeder/Background.json");
                var json = File.ReadAllText(filepath);
                var data = JsonConvert.DeserializeObject<IEnumerable<Background>>(json);
                _ctx.Backgrounds.AddRange(data);
                _ctx.SaveChanges();

                var background = _ctx.Backgrounds.Where(c => c.BackgroundTitle == "Guild Artisan").FirstOrDefault();
                var addskills = _ctx.AllowedSkills.Where(c => c.AllowedSkill == "Insight" | c.AllowedSkill == "Persuasion").ToList();
                var toolprof = _ctx.ToolProfs.Where(c => c.Type == "Artisan's tools").ToList();
                var language = _ctx.Languages.ToList();
                var equipment = _ctx.Items.Where(c => c.ItemName == "A letter of introduction from your guild"
                | c.ItemName == "Traveler's clothes"
                | c.ItemName == "Belt pouch containing 15 gp").ToList();

                background.BackgroundItem = equipment;
                background.BackgroundLanguage = language;
                background.BackgroundToolProf = toolprof;
                background.BackgroundSkill = addskills;
            }

            _ctx.SaveChanges();
        }
    }
}
