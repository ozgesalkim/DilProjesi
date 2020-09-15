using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DilProjesi.BLL.Models.DilDto
{
    public class BaseDilDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string Anahtar { get; set; }

        public string Aciklama { get; set; }
    }
}
