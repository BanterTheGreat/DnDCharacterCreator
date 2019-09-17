using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreator.Data;
using CharacterCreator.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CharacterCreator.Data
{
    public class CreatorRepository : ICreatorRepository
    {
        private readonly CreatorContext _ctx;
        private readonly ILogger<CreatorRepository> _logger;

        public CreatorRepository(CreatorContext ctx, ILogger<CreatorRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public void AddEntity(object model)
        {
            _ctx.Add(model);
        }

        public IEnumerable<Class> GetAllClasses()
        {
            return _ctx.Classes
                .Include(p => p.Proficiencies)
                    .ThenInclude(a => a.ArmorProf)
                .Include(p => p.Proficiencies)
                    .ThenInclude(w => w.WeaponProf)
                .Include(p => p.Proficiencies)
                    .ThenInclude(t => t.ToolProf)
                .Include(p => p.Proficiencies)
                    .ThenInclude(s => s.SavingThrows)
                .Include(p => p.Proficiencies)
                    .ThenInclude(z => z.AllowedSkills)
                .Include(a => a.Abilities)
                .Include(i => i.EquipmentChoices)
                .ToList();
        }

        public IEnumerable<Language> GetAllLanguages()
        {
               return _ctx.Languages
                           .ToList();
        }

        public IEnumerable<Proficiencies> GetAllProficiencies()
        {
            return _ctx.Proficiencies
                        .Include(a => a.ArmorProf)
                        .Include(w => w.WeaponProf)
                        .Include(t => t.ToolProf)
                        .Include(s => s.SavingThrows)
                        .Include(z => z.AllowedSkills)
                        .ToList();
        }

        public IEnumerable<Race> GetAllRaces()
        {
            return _ctx.Races
                        .Include(r => r.RaceTrait)
                        .Include(r => r.AbilityScoreIncrease)
                        .Include(l => l.Languages)
                        .ToList();
        }

        public IEnumerable<RaceTrait> GetRaceTraits(string race)
        {
            return _ctx.RaceTraits
                    .Where(r => r.Race == race).ToList();
                    
        }

        public IEnumerable<Abilities> GetAbilities(string input)
        {
            return _ctx.Abilities
                    .Where(a => a.Class == input).ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }

        public IEnumerable<Background> GetAllBackgrounds()
        {
            return _ctx.Backgrounds
            .Include(r => r.BackgroundItem)
            .Include(r => r.BackgroundLanguage)
            .Include(l => l.BackgroundToolProf)
            .Include(l => l.BackgroundSkill)
            .ToList();
        }
    }
}
