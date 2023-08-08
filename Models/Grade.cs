using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string? MaSv { get; set; }
        public int? tienganh { get; set; }
        public int? tinhoc { get; set; }
        public int? GDTC { get; set; }
        public float? DTB { get => (float)(tienganh + tinhoc + GDTC) / 3; /*set;*/ }
    }
}
