using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestBase.Models;

namespace TestAuth.Data
{
    public class AllContext : IdentityDbContext
    {
        public AllContext(DbContextOptions<AllContext> options)
            : base(options)
        {
        }
        public DbSet<Etudiant> etudiants { get; set; }
    }
}
