using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class Student
    {
        public string MaSV { get; set; }
        public string? HoTen { get; set; }
        public string? Email { get; set; }
        public string? SoDT { get; set; }
        public bool GioiTinh { get; set; }
        public string? Hinh { get; set; }
    }
}
