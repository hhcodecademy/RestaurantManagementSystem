using RMS.BL.Services.Interfaces;
using RMS.BL.Services;
using RMS.DAL.Models.Enums;
using RMS.DAL.Models;
using RMS.UI.Management.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.UI.Management
{
    internal class MenuManagement : ICustomManagement
    {
        private readonly IGenericService<Menu> _service;
        public MenuManagement()
        {
            _service = new GenericService<Menu>();
        }
        public void Add()
        {
            Menu item = new Menu();
            Console.WriteLine("Enter Menu name: ");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter Menu Type (1-3): ");
            int menuType = int.Parse(Console.ReadLine());
            item.MenuType = (MenuType)menuType;
            _service.Add(item);

            Console.WriteLine("\n Menu added successfully.\n");
        }
        public void GetAll()
        {
            var items = _service.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.MenuType} ");
            }
        }
        public void Get()
        {
            Console.WriteLine("Enter Menu id: ");
            int id = int.Parse(Console.ReadLine());
            var item = _service.Get(id);
            Console.WriteLine($"{item.Id} {item.Name} {item.MenuType} ");
        }
        public void Delete()
        {
            Console.WriteLine("Enter Menu id: ");
            int id = int.Parse(Console.ReadLine());
            _service.Delete(id);
            Console.WriteLine("Deleted Successfully.");
        }
        public void Update()
        {
            Menu item = new Menu();
            Console.WriteLine("Enter Menu name: ");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter Menu Type (1-3): ");
            int menuType = int.Parse(Console.ReadLine());
            item.MenuType = (MenuType)menuType;
            _service.Add(item);

            Console.WriteLine("\n Menu added successfully.\n");
            GetAll();
        }
    }
}

