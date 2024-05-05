using RMS.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL.Models
{
    public class Menu:BaseEntitiy
    {
        [StringLength(50)]
        public string Name { get; set; }

        public MenuType MenuType { get; set; }

        public ICollection<Food> Foods { get; set; }
        public Menu()
        {
                Foods = new List<Food>();
        }
    }
}
