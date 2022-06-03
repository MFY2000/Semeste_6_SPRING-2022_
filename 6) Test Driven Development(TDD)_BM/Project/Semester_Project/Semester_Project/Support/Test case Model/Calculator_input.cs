using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_Project.Support.Test_case_Model
{
    public class Calculator_param
    {
        public int sno { get; set; }
        public double input_1 { get; set; }
        public double input_2 { get; set; }
        public double Expected_output { get; set; }
        public string? Error_Message { get; set; }
        public bool status { get; set; }
    }
}
