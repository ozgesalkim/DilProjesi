using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.COMMON
{
    public class DataTableResponse<T>
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<T> Data { get; set; }
    }
}
