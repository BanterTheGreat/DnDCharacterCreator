using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class AbilityIncrease
    {
        public int Id { get; set; }
        public string Ability { get; set; }
        public int Increase { get; set; }
        public string Class { get; set; }
    }
}
