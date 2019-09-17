using CharacterCreator.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data
{
    public class CreatorContext : DbContext
    {

        public CreatorContext(DbContextOptions<CreatorContext> options) : base(options)
        {

        }
        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Abilities> Abilities { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Proficiencies> Proficiencies { get; set; }
        public DbSet<RaceTrait> RaceTraits { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<BackgroundVarSkill> BackgroundVarSkills { get; set; }
        public DbSet<BackgroundSkill> BackgroundSkills { get; set; }
        public DbSet<ArmorProf> ArmorProfs { get; set; }
        public DbSet<WeaponProf> WeaponProfs { get; set; }
        public DbSet<ToolProf> ToolProfs { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<AllowedSkills> AllowedSkills { get; set; }
        public DbSet<SavingThrows> SavingThrows { get; set; }
        public DbSet<AbilityScores> AbilityScores { get; set; }
        public DbSet<AbilityIncrease> AbilityIncreases { get; set; }
        public DbSet<EquipmentChoice> EquipmentChoices { get; set; }



    }
}
