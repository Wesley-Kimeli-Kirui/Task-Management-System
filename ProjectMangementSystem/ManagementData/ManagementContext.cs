using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectMangementSystem.Models;

namespace ManagementData
{
    public class ManagementContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<ProjectMangementSystem.Models.Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BVFIMS7;Initial Catalog = ManagementDatabase;Trusted_Connection=True; TrustServerCertificate=True; User Id = sa; Password= 63143679");
        }

    }
}