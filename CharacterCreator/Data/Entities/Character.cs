using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Class Class { get; set; }
        public Race Race { get; set; }
        public AbilityScores AbilityScores { get; set; }
        public Background Background { get; set; }
        public string Alignment { get; set; }
        public IList<Spell> Spells { get; set; }
    }


}
