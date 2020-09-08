using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.DOMAIN.Entities
{
    public class Sozcuk
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public int? FkProjeId { get; set; }

        public virtual Proje Proje { get; set; }
        public virtual ICollection<Tercume> Tercumeler { get; set; }
    }
}


