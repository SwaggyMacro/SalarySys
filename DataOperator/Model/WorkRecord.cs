using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.Model
{
    public class WorkRecord
    {
        public int id { get; set; }
        public string emp_name { get; set; }
        public int emp_id { get; set; }
        public DateTime clock_in_time { get; set; }
        public DateTime clock_off_time { get; set; }
        public int quantity { get; set; }
    }
}
