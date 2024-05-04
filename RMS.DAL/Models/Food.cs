using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL.Models
{
    public class Food:BaseEntitiy
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Menu> Menus { get; set; }
    }
}
