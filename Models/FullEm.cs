using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopt1.Models
{
    public class FullEm:Employees
    {
      int day;
       double dayprice;

        public  int _day
        {
            set { day = value; }
            get { return day; }

        }

        public double _dayrice
        {
            set { dayprice = value; }
            get { return dayprice; }

        }


        public override  bool check()
        {
         if(fname!=" " && lname!=" "&& email!=" " && phone!=" " && day!=0 && dayprice!=0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public override double cal()
        {
            double salary = day * dayprice;
            return salary;

        }





    }
}
