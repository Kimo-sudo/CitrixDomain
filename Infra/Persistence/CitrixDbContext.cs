using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Entities.KoffieBattle;
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
        public DbSet<KoffieBattle> KoffieBattleData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CitrixDbContext).Assembly);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }


    }

}