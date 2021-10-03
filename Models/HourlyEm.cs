using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopt1.Models
{
    public class HourlyEm:Employees
    {


       int hours;
      double hourprice;

        public int _hours
        {
            set { hours = value; }
            get { return hours; }

        }

        public double _hourprice
        {
            set { hourprice = value; }
            get { return hourprice; }

        }

        public override bool check()
        {
            if (fname != " " && lname != " " && email != " " && phone != " " && hours != 0 && hourprice != 0)
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
            double salary = hours* hourprice;
            return salary;

        }


    }
}
