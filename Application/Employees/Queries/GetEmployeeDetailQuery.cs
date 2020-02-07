using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Employees.Queries
{
    public class GetEmployeeDetailQuery: IRequest<Employee>
    {
        public int Id { get; set; }
        public class GetCustomerDetailQueryHandler : IRequestHandler<GetEmployeeDetailQuery, Employee>
        {
            private readonly ICitrixDbContext _context;

            public GetCustomerDetailQueryHandler(ICitrixDbContext context)
            {
                _context = context;
            }
            public async Task<Employee> Handle(GetEmployeeDetailQuery request, CancellationToken cancellationToken)
            {
                var entity = await _context.Employees
                    .FindAsync(request.Id);

                if (entity == null)
                {
                    throw new Exception();

                }

                return entity;
            }
        }
    }
}