using A_DAL.Interface;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Context;

namespace A_DAL.Responsitories
{
    public class GradeResponsitory : IGradeResponsitories
    {
        public Grade Add(Grade grade)
        {
            using (var context = new ContextString())
            {
                context.Grade.Add(grade);
                context.SaveChanges();
                return grade;
            }
        }

        public void Delete(Grade grade)
        {
            using (var context = new ContextString())
            {
                context.Attach(grade);
                context.Remove(grade);
                context.SaveChanges();
            }
        }

        public List<Grade> GetALL()
        {
            using (var context = new ContextString())
            {
                return context.Grade.ToList();
            }
        }

        public Grade GetById(int id)
        {
            using (var context = new ContextString())
            {
                return context.Grade.Find(id);
            }
        }

        public void Update(Grade grade)
        {
            using (var context = new ContextString())
            {
                context.Attach(grade);
                context.Update(grade);
                context.SaveChanges();
            }
        }
    }
}
