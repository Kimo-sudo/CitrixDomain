using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.KoffieBattle;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{

        public interface ICitrixDbContext
        {
            DbSet<Employee> Employees { get; set; }
            DbSet<Domain.Entities.KoffieBattle.KoffieBattle> KoffieBattleData { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
    
}