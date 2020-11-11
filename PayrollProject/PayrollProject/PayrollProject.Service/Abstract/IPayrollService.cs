using PayrollProject.Service.Concrete;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject.Service.Abstract
{
    /// <summary>
    /// Bordro metotlarını içerir.
    /// </summary>
    public interface IPayrollService
    {
        /// <summary>
        /// Tüm çalışanların maaş bordrolarını getirir.
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllPayrolls();
    }
}
