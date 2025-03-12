using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGroupe2.Model
{
    public class Patient:Personne
    {
        public int? IdGroupeSanguin { get; set; }
        [ForeignKey("IdGroupeSanguin")]
        public virtual GroupeSanguin GroupeSanguin { get; set; }
        [Required]
        public float Poids { get; set; }
        [Required]
        public float Taille { get; set; }
        public DateTime DateNaissance { get; set; }
    }
}
