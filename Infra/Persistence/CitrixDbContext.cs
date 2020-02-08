using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Entities.Battle;
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
        public DbSet<KoffieBattle> KoffieBattle { get; set; }
        public DbSet<BattleInput> InputBattleData { get; set; }
        public DbSet<FranchiseBattle> GenericBattle { get; set; }
        public DbSet<FranchiseBattle> KoffieBattleInput { get; set; }

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