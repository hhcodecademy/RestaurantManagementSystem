using RMS.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL.Models
{
    public class Customer : Person
    {
        public CustomerType CustomerType { get; set; }
    }
}
