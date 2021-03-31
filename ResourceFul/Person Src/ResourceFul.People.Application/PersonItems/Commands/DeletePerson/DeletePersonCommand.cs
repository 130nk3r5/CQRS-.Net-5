using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ResourceFul.People.Application.Common.Exceptions;
using ResourceFul.People.Application.Common.Interfaces;

namespace ResourceFul.People.Application.PersonItems.Commands.DeletePerson
{
    public class DeletePersonCommand : IRequest
    {
        public long PersonId { get; set; }

        public DeletePersonCommand()
        {
        }
    }

    public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand>
    {
        private readonly IPersonDbContext _context;

        public DeletePersonCommandHandler(IPersonDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.People.FindAsync(request.PersonId);

            if (entity == null)
                throw new NotFoundException(nameof(Person), request.PersonId);

            _context.People.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
