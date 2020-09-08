using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.DOMAIN.Entities
{
    public class Dil
    {
        public int Id { get; set; }

         public string Ad { get; set; }

         public string Anahtar { get; set; }

         public string Aciklama { get; set; }

        public virtual ICollection<Tercume> Tercumeler { get; set; }
    }
}
