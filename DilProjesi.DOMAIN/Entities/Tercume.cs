using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.DOMAIN.Entities
{
     public class Tercume
    {
        public int Id { get; set; }

        public int FkSozcukId { get; set; }

        public int FkDilId { get; set; }

        public string Ceviri { get; set; }

        public virtual Dil Dil { get; set; }
        public virtual Sozcuk Sozcuk { get; set; }
    }
}
