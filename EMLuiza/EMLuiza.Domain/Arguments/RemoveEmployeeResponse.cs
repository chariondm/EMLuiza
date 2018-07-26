using EMLuiza.Domain.Entities;
using EMLuiza.Domain.Interfaces.Arguments;
using System;

namespace EMLuiza.Domain.Arguments
{
    public class RemoveEmployeeResponse : IResponse
    {
        public RemoveEmployeeResponse(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}
