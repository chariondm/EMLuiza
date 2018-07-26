using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Interfaces.Arguments;
using System;

namespace EMLuiza.Domain.Arguments
{
    public class AddEmployeeResponse : IResponse
    {
        public AddEmployeeResponse(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}
