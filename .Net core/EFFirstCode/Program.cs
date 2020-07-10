using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFFirstCode
{
    class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    class EFCoreQorganization:DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var efCntx = new EFCoreQorganization();
            // Select all department
            List<Department> Depts = efCntx.Departments.ToList();

            var D = new Department() { Description = "Development", Name = "Dev" };

            efCntx.Departments.Add(D);

            efCntx.SaveChanges();

            Console.WriteLine("Hello World!");
        }
    }
}
