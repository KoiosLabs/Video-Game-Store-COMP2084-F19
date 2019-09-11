using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Video_Game_Store_COMP2084_F19.Models
{
    public class Game
    {
        
        public virtual int Id { get; set; }

        
        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        public virtual String MinimumRequirements { get; set; }
        public virtual Decimal Price { get; set; }
        public virtual String Developer { get; set; }

    }
}
