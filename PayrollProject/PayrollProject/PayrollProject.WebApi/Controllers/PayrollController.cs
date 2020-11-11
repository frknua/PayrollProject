using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollProject.Service.Abstract;
using PayrollProject.Service.Concrete;

namespace PayrollProject.WebApi.Controllers
{
    [ApiController]
    public class PayrollController : ControllerBase
    {
        readonly IPayrollService _payrollService;

        public PayrollController(IPayrollService payrollService)
        {
            _payrollService = payrollService;
        }

        [HttpGet]
        [Route("get-all-payrolls")]
        public List<Employee> Get()
        {
            return _payrollService.GetAllPayrolls();
        }
    }
}