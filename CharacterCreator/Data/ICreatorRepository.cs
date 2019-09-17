using System.Collections.Generic;
using CharacterCreator.Data.Entities;

namespace CharacterCreator.Data
{
    public interface ICreatorRepository
    {
        void AddEntity(object model);
        IEnumerable<Language> GetAllLanguages();
        bool SaveAll();
        IEnumerable<Race> GetAllRaces();
        IEnumerable<Proficiencies> GetAllProficiencies();

        IEnumerable<Class> GetAllClasses();
        IEnumerable<RaceTrait> GetRaceTraits(string race);
        IEnumerable<Abilities> GetAbilities(string input);
        IEnumerable<Background> GetAllBackgrounds();
    }
}