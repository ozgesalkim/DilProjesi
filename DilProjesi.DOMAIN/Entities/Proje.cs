using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.DOMAIN.Entities
{
    public class Proje
    {
        public int Id { get;  set; }

        public string Ad { get; set; }

        public virtual ICollection<Sozcuk> Sozcukler { get; set; }
    }
}
