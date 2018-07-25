using EMLuiza.Domain.Interfaces.Arguments;
using System;

namespace EMLuiza.Domain.Arguments
{
    public class RemoveEmployeeRequest : IRequest
    {
        public RemoveEmployeeRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
