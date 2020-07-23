using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntCommunityBlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;


namespace AntCommunityBlazorApp.Server.DataAccess
{
    public class EmployeeContext
    {
        public virtual DbSet<Employee> tblEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Put Your Connection string here");
            }   
        }
    }
}
