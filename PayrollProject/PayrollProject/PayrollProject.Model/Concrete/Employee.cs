using PayrollProject.Service.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollProject.Service.Concrete
{
    /// <summary>
    /// Çalışanlar classı
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Çalışan Id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Çalışan Tipi
        /// </summary>
        public EmployeeType EmployeeTypeId { get; set; }

        /// <summary>
        /// Kimlik Numarası
        /// </summary>
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Adı
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Soyadı
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Maaş
        /// </summary>
        public decimal Salary
        {
            get
            {
                switch (EmployeeTypeId)
                {
                    case EmployeeType.Type1:
                        return FixedMontlySalary;                  
                    case EmployeeType.Type2:
                        return WorkedDayCount * DailyPrice;                  
                    case EmployeeType.Type3:
                        return FixedMontlySalary + (OvertimeHourCount * OvertimeHourlyPrice);
                    case EmployeeType.Type4:
                        return (WorkedDayCount * DailyPrice) + (OvertimeHourCount * OvertimeHourlyPrice);
                    default:
                        return 0;
                }
            }
        }

       // public decimal Salary { get; set; }

        /// <summary>
        /// Çalışılan gün sayısı
        /// </summary>
        public int WorkedDayCount { get; set; }

        /// <summary>
        /// Günlük Ücret
        /// </summary>
        public decimal DailyPrice { get; set; }

        /// <summary>
        /// Sabit aylık maaş
        /// </summary>
        public decimal FixedMontlySalary { get; set; }

        /// <summary>
        /// Fazla mesai saati
        /// </summary>
        public int OvertimeHourCount { get; set; }

        /// <summary>
        /// Fazla mesai saat ücreti
        /// </summary>
        public decimal OvertimeHourlyPrice { get; set; }
    }
}
