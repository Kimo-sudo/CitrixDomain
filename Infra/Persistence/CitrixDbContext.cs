using System.Reflection;
using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistence
{
    public class CitrixDbContext : DbContext, ICitrixDbContext
    {

        public CitrixDbContext(DbContextOptions<CitrixDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CitrixDbContext).Assembly);
        }


    }

}