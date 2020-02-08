using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.Battle;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{

        public interface ICitrixDbContext
        {
            //
            DbSet<Employee> Employees { get; set; }

            // Battle
            DbSet<KoffieBattle> KoffieBattle { get; set; }
            DbSet<BattleInput> InputBattleData { get; set; }
            DbSet<FranchiseBattle> GenericBattle { get; set; }
        

            Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
    
}