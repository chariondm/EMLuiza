using EMLuiza.Api.Controllers.Base;
using EMLuiza.Domain.Arguments;
using EMLuiza.Domain.Interfaces.Services;
using EMLuiza.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace EMLuiza.Api.Controllers
{
    [RoutePrefix("employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IServiceEmployee _serviceEmployee;

        public EmployeeController(IUnitOfWork unitOfWork, IServiceEmployee serviceEmployee) : base(unitOfWork)
        {
            _serviceEmployee = serviceEmployee;
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Create(AddEmployeeRequest request)
        {
            try
            {
                var response = _serviceEmployee.Create(request);

                return await ResponseAsync(response, _serviceEmployee);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}