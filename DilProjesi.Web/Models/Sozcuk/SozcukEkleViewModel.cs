using DilProjesi.BLL.Models.DilDto;
using DilProjesi.BLL.Models.SozcukDto;
using DilProjesi.BLL.Models.TercumeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DilProjesi.Web.Models.Sozcuk
{
    public class SozcukEkleViewModel
    {
        public CreateSozcukDto Sozcuk { get; set; }
        public List<CheckBoxDilDto> Diller { get; set; }
    }
}
