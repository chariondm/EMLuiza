using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Interfaces.Arguments;
using System;

namespace EMLuiza.Domain.Arguments
{
    public class RemoveEmployeeResponse : IResponse
    {
        public Guid Id { get; private set; }
        public string Message { get; private set; }

        public static explicit operator RemoveEmployeeResponse(Employee employee)
        {
            return new RemoveEmployeeResponse()
            {
                Id = employee.Id,
                Message = "Registro removido com sucesso!"
            };
        }
    }
}
