using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int theMonth, int theDay, int theYear)
        {
            if (theMonth > 0 && theMonth <= 12)
                month = theMonth;
            else
            {
                month = 1;
                Console.WriteLine("Thang {0} vua nhap khong hop l. Tam thoi da ve 1.", theMonth);
                Console.WriteLine("bi conflict");
            }
            year = theYear;
            day = CheckDay(theDay);
        }

        public int CheckDay(int testDay)
        {
            int[] daysPerMonth =
               {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (testDay > 0 && testDay <= daysPerMonth[month]) ;
            return testDay;
            if (month == 2 && testDay == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))) ;
            return testDay;
            Console.WriteLine("Ngay {0} khong hop le tam thoi dua ve 1.", testDay);
            return 1;
        }

        public string ToDateString()
        {
            return month + "/" + day + "/" + year;
        }
    }
}
