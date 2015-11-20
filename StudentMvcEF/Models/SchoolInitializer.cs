using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentMvcEF.Models
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student {FirstName = "James", LastName = "Dean"},
            new Student {FirstName = "Neil", LastName = "Peart"}
            };
            foreach (var temp in students)
            {
                context.Students.Add(temp);
            }
            context.SaveChanges();
        }
    }
}