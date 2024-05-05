using RMS.BL.Services.Interfaces;
using RMS.BL.Services;
using RMS.DAL.Models;
using RMS.UI.Management.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.DAL.Models.Enums;

namespace RMS.UI.Management
{
    internal class EmployeeManagement : ICustomManagement
    {
        private readonly IGenericService<Employee> _service;
        public EmployeeManagement()
        {
            _service = new GenericService<Employee>();
        }
        public void Add()
        {
            Employee item = new Employee();
            Console.WriteLine("Enter employee name: ");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter employee surname: ");
            item.Surname = Console.ReadLine();
            Console.WriteLine("Enter employeer DOB: ");
            item.DOB = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee salary: ");
            item.Salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter empoloyee Type (1-4): ");
            int empType = int.Parse(Console.ReadLine());
            item.EmployeeType = (EmployeeType)empType;
            Console.WriteLine("Enter contract Type (1-4): ");
            int contractType = int.Parse(Console.ReadLine());
            item.ContractType = (ContractType)contractType;
            _service.Add(item);

            Console.WriteLine("\n Employee added successfully.\n");
        }

        public void Delete()
        {
            Console.WriteLine("Enter Employee id: ");
            int id = int.Parse(Console.ReadLine());
            _service.Delete(id);
            Console.WriteLine("Deleted Successfully.");
        }

        public void Get()
        {
            Console.WriteLine("Enter Employee id: ");
            int id = int.Parse(Console.ReadLine());
            var item = _service.Get(id);
            Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.DOB} {item.EmployeeType.ToString()} {item.ContractType.ToString()} {item.Salary} ");
        }

        public void GetAll()
        {
            var items = _service.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.DOB} {item.EmployeeType.ToString()} {item.ContractType.ToString()} {item.Salary} ");
            }
        }

        public void Update()
        {
            Employee item = new Employee();
            Console.WriteLine("Enter employee name: ");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter employee surname: ");
            item.Surname = Console.ReadLine();
            Console.WriteLine("Enter employeer DOB: ");
            item.DOB = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee salary: ");
            item.Salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter empoloyee Type (1-4): ");
            int empType = int.Parse(Console.ReadLine());
            item.EmployeeType = (EmployeeType)empType;
            Console.WriteLine("Enter contract Type (1-4): ");
            int contractType = int.Parse(Console.ReadLine());
            item.ContractType = (ContractType)contractType;
            _service.Add(item);
            Console.WriteLine("\n Employee added successfully.\n");
            GetAll();
        }
    }
}
