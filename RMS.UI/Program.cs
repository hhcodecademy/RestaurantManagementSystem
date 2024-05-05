using RMS.UI.Management;
using RMS.UI.Management.Interfaces;

namespace RMS.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenuManagement menu = new MainMenuManagement();
            ICustomManagement management;

            int selection = menu.MainMenu();
            bool flag = true;
            do
            {
                switch (selection)
                {

                    case 1:
                        management=new RestaurantManagement();
                        int selectRes = menu.SubMenu(selection);
                        switch (selectRes)
                        {
                            case 1:
                                management.Add();
                                break;
                            case 2:
                                management.GetAll();
                                break;
                            case 3:
                                management.Get();
                                break;
                            case 4:
                                management.Delete();
                                break;
                            case 5:
                                management.Update();
                                break;
                            case 6:
                                selection = menu.MainMenu();
                                break;
                        }
                        break;
                    case 2:
                        management = new CustomerManagement();
                        int selectCst = menu.SubMenu(selection);
                        switch (selectCst)
                        {
                            case 1:
                                management.Add();
                                break;
                            case 2:
                                management.GetAll();
                                break;
                            case 3:
                                management.Get();
                              
                                break;
                            case 4:
                                management.Delete();
                                 break;
                            case 5:
                                management.Update();
                             
                                break;
                            case 6:
                                selection = menu.MainMenu();
                                break;
                        }

                                break;

                        case 3:
                        management = new EmployeeManagement();
                        int selectEmp = menu.SubMenu(selection);
                        switch (selectEmp)
                        {
                            case 1:
                                management.Add();
                                break;
                            case 2:
                                management.GetAll();
                                break;
                            case 3:
                                management.Get();

                                break;
                            case 4:
                                management.Delete();
                                break;
                            case 5:
                                management.Update();

                                break;
                            case 6:
                                selection = menu.MainMenu();
                                break;
                        }

                        break;
                    case 4:
                        management = new FoodManagement();
                        int selectFood = menu.SubMenu(selection);
                        switch (selectFood)
                        {
                            case 1:
                                management.Add();
                                break;
                            case 2:
                                management.GetAll();
                                break;
                            case 3:
                                management.Get();

                                break;
                            case 4:
                                management.Delete();
                                break;
                            case 5:
                                management.Update();

                                break;
                            case 6:
                                selection = menu.MainMenu();
                                break;
                        }

                        break;
                    case 5:
                        management = new MenuManagement();
                        int selectMenu = menu.SubMenu(selection);
                        switch (selectMenu)
                        {
                            case 1:
                                management.Add();
                                break;
                            case 2:
                                management.GetAll();
                                break;
                            case 3:
                                management.Get();

                                break;
                            case 4:
                                management.Delete();
                                break;
                            case 5:
                                management.Update();

                                break;
                            case 6:
                                selection = menu.MainMenu();
                                break;
                        }

                        break;
                    case 6:
                        flag = false;
                        break;
                }
            } while (flag);
        }
    }
}
