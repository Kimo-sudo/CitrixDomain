using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Entities.Battle;
using Domain.Enum;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.KoffieBattles.Commands
{
    public class AddKoffieBattleDataCommand : IRequest<string>
    {
        public int Id { get; set; }
        public int GroteKoffie { get; set; }
        public int MediumKoffie { get; set; }
        public Restaurant Restaurant { get; set; }
        public DateTime DatumVerstuurd { get; set; } 
        public string VerstuurdDoor { get; set; }

        public class AddKoffieBattleDataCommandHandler : IRequestHandler<AddKoffieBattleDataCommand, string>
        {
            private readonly ICitrixDbContext _context;

            public AddKoffieBattleDataCommandHandler(ICitrixDbContext context)
            {
                _context = context;
            }
            // TODO: Omzetten naar void
            // TODO: IF identity is toegevoegd: VerstuurdDoor automatisch laten importen
            public async Task<string> Handle(AddKoffieBattleDataCommand request, CancellationToken cancellationToken)
            {
                var manager = await _context.Employees.FirstOrDefaultAsync(x => x.FirstName + x.LastName == request.VerstuurdDoor, cancellationToken);
                if (manager == null)
                {
                    return $"Kan geen manager met de naam : { request.VerstuurdDoor }, probeer het opnieuw";
                }
                else
                {
                    var entity = new KoffieBattle()
                    {
                        Id = request.Id,
                        DatumVerstuurd = DateTime.Now,
                        GroteKoffie = request.GroteKoffie, 
                        MediumKoffie = request.MediumKoffie, 
                        Restaurant =  manager.Restaurant,
                        VerstuurdDoor = manager
                    };
                    _context.KoffieBattle.Add(entity);
                    await _context.SaveChangesAsync(cancellationToken);
                    return $"Je gegevens zijn verwerkt!";
                }
            }
        }
    }
}