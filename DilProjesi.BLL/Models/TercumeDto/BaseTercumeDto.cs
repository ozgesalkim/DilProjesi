using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.TercumeDto
{
    public class BaseTercumeDto
    {
        public int Id { get; set; }

        public int FkSozcukId { get; set; }

        public int FkDilId { get; set; }

        public string Ceviri { get; set; }
    }
}
