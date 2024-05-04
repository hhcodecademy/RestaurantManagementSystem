using RMS.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL.Models
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public ContractType ContractType { get; set; }
    }
}
