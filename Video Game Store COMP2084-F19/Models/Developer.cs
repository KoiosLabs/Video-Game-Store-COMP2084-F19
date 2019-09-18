using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Video_Game_Store_COMP2084_F19.Models
{
    public class Developer
    {
        [Key]
        public virtual int DeveloperId { get; set; }

        public virtual String Name { get; set; }
        public virtual String StreetAddress { get; set; }
        public virtual String City { get; set; }
        public virtual String Telephone { get; set; }

        public virtual List<Game> Games { get; set; }
    }
}
