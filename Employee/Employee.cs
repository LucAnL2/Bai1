using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        private Date birthDate;
        private string firstName;
        private Date hireDate;
        private string lastName;

        public Employee(string first, string last, int birthMonth, int birthDay, int birdYear, int hireMonth, int hireDay, int hireYear)
        {
            firstName = first;
            lastName = last;
            birthDate = new Date(birthMonth, birthDay, birdYear);
            hireDate = new Date(hireMonth, hireDay, hireYear); firstName = first;
            lastName = last;
            birthDate = new Date(birthMonth, birthDay, birdYear);
            hireDate = new Date(hireMonth, hireDay, hireYear);
        }

        public string ToEmployeeString()
        {
            return lastName + ", " + firstName + ", " + " Hire: " + hireDate.ToString() + " BirthDay: " + birthDate.ToDateString();
        }
    }
}
