using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class EquipmentChoice
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string Choice1 { get; set; }

        public string Choice2 { get; set; }
    }
}
