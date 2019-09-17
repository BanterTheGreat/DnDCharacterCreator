using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class Race
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public ICollection<AbilityIncrease> AbilityScoreIncrease { get; set; }
        public ICollection<RaceTrait> RaceTrait { get; set; }
        public string Age { get; set; }
        public string Alignment { get; set; }
        public string Size { get; set; }
        public string Speed { get; set; }
        public ICollection<Language> Languages { get; set; }

    }
}
