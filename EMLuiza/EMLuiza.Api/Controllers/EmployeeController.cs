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

        [Route("")]
        [HttpPost]
        public async Task<HttpResponseMessage> Create(AddEmployeeRequest req)
        {
            try
            {
                var response = _serviceEmployee.Create(req);

                return await ResponseAsync(response, _serviceEmployee);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("")]
        [HttpGet]
        public async Task<HttpResponseMessage> List(int page_size = 10, int page = 1)
        {
            try
            {
                var response = _serviceEmployee.List(page_size, page);

                return await ResponseAsync(response, _serviceEmployee);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("")]
        [HttpDelete]
        public async Task<HttpResponseMessage> Remove(RemoveEmployeeRequest req)
        {
            try
            {
                var response = _serviceEmployee.Remove(req);

                return await ResponseAsync(response, _serviceEmployee);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}