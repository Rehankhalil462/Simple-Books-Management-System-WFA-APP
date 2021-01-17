using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class IssuanceClass
    {
        public string Student_Name { get; set; }
        public string Department { get; set; }
        public string Roll_No { get; set; }
        public string Category { get; set; }
        public string Book_Name { get; set; }
        public DateTime Issuance_Date { get; set; }
        public DateTime Due_Date { get; set; }
    }
}
