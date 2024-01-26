using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Employee
{
    public class Program
    {
        public static void Main(string[] avrgs)
        {
            Employee e = new Employee("Bob", "Jones", 2, 2, 1989, 3, 12, 2016);
            MessageBox.Show(e.ToEmployeeString(), "Testing Class Employee");
        }
    }
}