using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.SozcukDto
{
    public class BaseSozcukDto
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public int? FkProjeId { get; set; }
    }
}
