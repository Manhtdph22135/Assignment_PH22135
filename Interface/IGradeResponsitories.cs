using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Interface
{
    public interface IGradeResponsitories
    {
        List<Grade> GetALL();
        Grade GetById(int id);
        Grade Add(Grade grade);
        void Delete(Grade grade);
        void Update(Grade grade);
    }
}
