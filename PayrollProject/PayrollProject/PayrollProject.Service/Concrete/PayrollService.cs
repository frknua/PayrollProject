using PayrollProject.Service.Abstract;
using PayrollProject.Service.Enumerations;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject.Service.Concrete
{
    /// <summary>
    /// Bordro verilerini döndüren servistir.
    /// </summary>
    public class PayrollService : IPayrollService
    {
        /// <summary>
        /// Bordro verilerini döndürür.
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllPayrolls()
        {
            List<Employee> list = new List<Employee>();
            list.Add(
                new Employee()
                {
                    EmployeeId = 1,
                    Name = "Furkan",
                    Surname = "Uzunçakmak",
                    EmployeeTypeId = EmployeeType.Type1,
                    IdentityNumber = "123456789",
                    WorkedDayCount = 5,
                    DailyPrice = 100,
                    FixedMontlySalary = 1000,
                    OvertimeHourCount = 50,
                    OvertimeHourlyPrice = 50
                });
            list.Add(
               new Employee()
               {
                   EmployeeId = 2,
                   Name = "Furkan",
                   Surname = "Uzunçakmak",
                   EmployeeTypeId = EmployeeType.Type2,
                   IdentityNumber = "123456789",
                   WorkedDayCount = 5,
                   DailyPrice = 100,
                   FixedMontlySalary = 1000,
                   OvertimeHourCount = 50,
                   OvertimeHourlyPrice = 50
               });
            list.Add(
              new Employee()
              {
                  EmployeeId = 3,
                  Name = "Furkan",
                  Surname = "Uzunçakmak",
                  EmployeeTypeId = EmployeeType.Type3,
                  IdentityNumber = "123456789",
                  WorkedDayCount = 5,
                  DailyPrice = 100,
                  FixedMontlySalary = 1000,
                  OvertimeHourCount = 50,
                  OvertimeHourlyPrice = 50
              });
            list.Add(
              new Employee()
              {
                  EmployeeId = 4,
                  Name = "Furkan",
                  Surname = "Uzunçakmak",
                  EmployeeTypeId = EmployeeType.Type4,
                  IdentityNumber = "123456789",
                  WorkedDayCount = 5,
                  DailyPrice = 100,
                  FixedMontlySalary = 1000,
                  OvertimeHourCount = 50,
                  OvertimeHourlyPrice = 50
              });
            return list;
        }
    }
}
