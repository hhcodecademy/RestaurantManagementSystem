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
    internal class FoodManagement : ICustomManagement
    {
        private readonly IGenericService<Food> _service;
        private readonly IGenericService<Menu> _menuService;
        public FoodManagement()
        {
            _service = new GenericService<Food>();
            _menuService = new GenericService<Menu>();
        }
        public void Add()
        {
            Food item = new Food();
            Console.WriteLine("Enter Food title: ");
            item.Title = Console.ReadLine();
            Console.WriteLine("Enter Food description: ");
            item.Description = Console.ReadLine();
            var addedFood=   _service.Add(item);

            MenuManagement menuManagment = new MenuManagement();
            menuManagment.GetAll();
            Console.WriteLine("Select menu : ");
            int menuId = int.Parse(Console.ReadLine());
            Menu menu = _menuService.Get(menuId);

            menu.Foods.Add(item);

            _menuService.Update(menu.Id, menu);

            Console.WriteLine("\n Food added successfully.\n");
        }
        public void GetAll()
        {
            var items = _service.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} {item.Title} {item.Description} ");
            }
        }
        public void Get()
        {
            Console.WriteLine("Enter Food id: ");
            int id = int.Parse(Console.ReadLine());
            var item = _service.Get(id);
            Console.WriteLine($"{item.Id} {item.Title} {item.Description} ");
        }
        public void Delete()
        {
            Console.WriteLine("Enter Food id: ");
            int id = int.Parse(Console.ReadLine());
            _service.Delete(id);
            Console.WriteLine("Deleted Successfully.");
        }
        public void Update()
        {
            Food item = new Food();
            Console.WriteLine("Enter Food title: ");
            item.Title = Console.ReadLine();
            Console.WriteLine("Enter Food description: ");
            item.Title = Console.ReadLine();
            _service.Add(item);

            Console.WriteLine("\n Food added successfully.\n");
            GetAll();
        }
    }
}
