using RMS.BL.Services.Interfaces;
using RMS.BL.Services;
using RMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.UI.Management.Enums;
using System.ComponentModel.Design;
using RMS.DAL.Models.Enums;
using RMS.UI.Management.Interfaces;

namespace RMS.UI.Management
{
    internal class CustomerManagement:ICustomManagement
    {
        private readonly IGenericService<Customer> _service;
        public CustomerManagement()
        {
            _service = new GenericService<Customer>();
        }
        public void Add()
        {
            Customer item = new Customer();
            Console.WriteLine("Enter customer name: ");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter customer surname: ");
            item.Surname = Console.ReadLine();
            Console.WriteLine("Enter customer DOB: ");
            item.DOB = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter customer Type (1-2): ");
            int cstType = int.Parse(Console.ReadLine());
            item.CustomerType = (CustomerType)cstType;
            _service.Add(item);

            Console.WriteLine("\n Customer added successfully.\n");
        }
        public void GetAll()
        {
            var items = _service.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.DOB} {item.CustomerType} ");
            }
        }
        public void Get()
        {
            Console.WriteLine("Enter Customer id: ");
            int id = int.Parse(Console.ReadLine());
            var item = _service.Get(id);
            Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.DOB} {item.CustomerType} ");
        }
        public void Delete()
        {
            Console.WriteLine("Enter Customer id: ");
            int id = int.Parse(Console.ReadLine());
            _service.Delete(id);
            Console.WriteLine("Deleted Successfully.");
        }
        public void Update()
        {
            Customer item = new Customer();
            Console.WriteLine("Enter customer name: ");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter customer surname: ");
            item.Surname = Console.ReadLine();
            Console.WriteLine("Enter customer DOB: ");
            item.DOB = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter customer Type (1-2): ");
            int cstType = int.Parse(Console.ReadLine());
            item.CustomerType = (CustomerType)cstType;
            _service.Add(item);

            Console.WriteLine("\n Customer added successfully.\n");
            GetAll();
        }
    }
}
