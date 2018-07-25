using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Interfaces.Arguments;
using System;

namespace EMLuiza.Domain.Arguments
{
    public class AddEmployeeResponse : IResponse
    {
        public Guid Id { get; private set; }
        public string Message { get; private set; }

        public static explicit operator AddEmployeeResponse(Employee employee)
        {
            return new AddEmployeeResponse()
            {
                Id = employee.Id,
                Message = "Operação realizada com sucesso!"
            };
        }
    }
}
