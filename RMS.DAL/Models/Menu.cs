using RMS.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL.Models
{
    public class Menu:BaseEntitiy
    {
        public string Name { get; set; }

        public MenuType MenuType { get; set; }

        public ICollection<Food> Foods { get; set; }

    }
}
