using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL.Models
{
    public  class BaseEntitiy
    {
        public int Id { get; set; }
        public DateOnly CreateDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
