using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;


namespace Application.KoffieBattles.Queries
{
    public class GetCurrentMonthQuery : IRequest<List<FranchiseBattle>>
    {
        public class
            GetCurrentMonthQueryHandler : IRequestHandler<GetCurrentMonthQuery, List<FranchiseBattle>>
        {
            private readonly ICitrixDbContext _context;

            public GetCurrentMonthQueryHandler(ICitrixDbContext context)
            {
                _context = context;
            }

            public async Task<List<FranchiseBattle>> Handle(GetCurrentMonthQuery request, CancellationToken cancellationToken)
            {
                var result =
                    await _context.GenericBattle
                        .Include(x => x.RestaurantInput)
                        .ThenInclude(x => x.Gegevens)
                        .ThenInclude(x => x.VerstuurdDoor)
                        .ToListAsync(cancellationToken);
                return result;
            }
        }
    }
}