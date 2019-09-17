using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string School { get; set; }
        public string Level { get; set; }
        public string Desc { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }

        public string Components { get; set; }
        public ICollection<Material> Materials {get; set; }
        public string Duration { get; set; }
        
    }



}

//TODO START DOTNET EF DATABASE UPDATE