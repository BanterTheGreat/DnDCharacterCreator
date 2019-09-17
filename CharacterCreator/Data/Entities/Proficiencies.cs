using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class Proficiencies
    {
        
        public int Id { get; set; }
        public string Class { get; set; }
        public ICollection<ArmorProf> ArmorProf { get; set; }
        public ICollection<WeaponProf> WeaponProf { get; set; }
        public ICollection<ToolProf> ToolProf { get; set; }
        public ICollection<SavingThrows> SavingThrows { get; set; }
        public int SkillsProfAmount { get; set; }
        public ICollection<AllowedSkills> AllowedSkills { get; set; }

    }


}
