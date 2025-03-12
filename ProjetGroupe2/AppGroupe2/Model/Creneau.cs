using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGroupe2.Model
{
    public class Creneau
    {
        [Key]
        public int IdCreneau { get; set; }
        public TimeSpan HeureDebut { get; set; }
        public TimeSpan HeureFin { get; set; }
    }
}
