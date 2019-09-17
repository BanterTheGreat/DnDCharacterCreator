using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class RaceTrait
    {
        public int Id { get; set; }
        public string Race { get; set; }

        public string TraitName { get; set; }
        public string TraitDesc { get; set; }
    }
}
