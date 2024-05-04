using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.BL.Services;
using RMS.BL.Services.Interfaces;
using RMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.UI.Management
{
    internal class RestaurantManagement
    {
        private readonly IGenericService<Restaurant> _service;
        public RestaurantManagement()
        {
            _service = new GenericService<Restaurant>();
        }
        public void AddRestaurant()
        {
            Restaurant restaurant = new Restaurant();
            Console.WriteLine("Enter restaurant name: ");
            restaurant.Name = Console.ReadLine();
            Console.WriteLine("Enter restaurant address: ");
            restaurant.Address = Console.ReadLine();
            Console.WriteLine("Enter restaurant description: ");
            restaurant.Description = Console.ReadLine();
            Console.WriteLine("Enter restaurant phone: ");
            restaurant.Phone = Console.ReadLine();
            Console.WriteLine("Enter restaurant email: ");
            restaurant.Email = Console.ReadLine();
            _service.Add(restaurant);
            Console.WriteLine("\nRestaurant added successfully.\n");
        }
        public void GetAllRestaurants() 
        {
            var restaurants = _service.GetAll();
            foreach (var item in restaurants)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Address} {item.Description} {item.Phone} {item.Email}");
            }
        }
        public void GetRestaurant()
        {
            Console.WriteLine("Enter restaurant id: ");
            int id = int.Parse(Console.ReadLine());
            var item = _service.Get(id);
            Console.WriteLine($"{item.Id} {item.Name} {item.Address} {item.Description} {item.Phone} {item.Email}");
        }
        public void DeleteRestaurant()
        {
            Console.WriteLine("Enter restaurant id: ");
            int id = int.Parse(Console.ReadLine());
            _service.Delete(id);
            Console.WriteLine("Deleted Successfully.");
        }
        public void UpdateRestaurant()
        {
            Restaurant restaurant = new Restaurant();
            Console.WriteLine("Enter restaurant id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter restaurant name: ");
            restaurant.Name = Console.ReadLine();
            Console.WriteLine("Enter restaurant address: ");
            restaurant.Address = Console.ReadLine();
            Console.WriteLine("Enter restaurant description: ");
            restaurant.Description = Console.ReadLine();
            Console.WriteLine("Enter restaurant phone: ");
            restaurant.Phone = Console.ReadLine();
            Console.WriteLine("Enter restaurant email: ");
            restaurant.Email = Console.ReadLine();
            _service.Update(id, restaurant);
            Console.WriteLine("\nUpdated Successfully.\n");
            GetAllRestaurants();
        }
    }
}
