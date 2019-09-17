using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HitDice { get; set; }
        public Proficiencies Proficiencies { get; set; }
        public ICollection<EquipmentChoice> EquipmentChoices { get; set; }
        public ICollection<Abilities> Abilities { get; set; }
    }


}
