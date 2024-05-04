using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL.Models
{
    public abstract class Person:BaseEntitiy
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly DOB { get; set; }
    }
}
