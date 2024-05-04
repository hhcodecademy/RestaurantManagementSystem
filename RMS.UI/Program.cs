using RMS.UI.Management;

namespace RMS.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RestaurantManagement management = new RestaurantManagement();
            management.UpdateRestaurant();
        }
    }
}
