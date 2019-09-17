using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class Background
    {
        public int Id { get; set; }
        public string BackgroundTitle { get; set; }
        public ICollection<Language> BackgroundLanguage { get; set; }
        public string BackgroundAbility { get; set; }
        public ICollection<ToolProf> BackgroundToolProf { get; set; }
        public ICollection<AllowedSkills> BackgroundSkill { get; set; }
        public ICollection<AllowedSkills> BackgroundVarSkill { get; set; }
        public ICollection<Item> BackgroundItem { get; set; }

    }

}