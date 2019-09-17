using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class Abilities
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string AbilityTitle { get; set; }
        public string AbilityDesc { get; set; }
    }
}
