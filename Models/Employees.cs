using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopt1.Models
{
    public abstract class Employees
    {
        protected String fname;
       protected String lname;
       protected String email;
        protected String phone;
        protected String type;

        public String _fname
        {
            set { fname = value; }
            get { return fname; }

        }

        public String _lname
        {
            set { lname = value; }
            get { return lname; }

        }

        public String _email
        {
            set { email = value; }
            get { return email; }


        }
        public String  _phone
        {
            set { phone = value; }
            get { return phone; }

        }
        public String _taybe
        {
            set { type = value; }
            get { return type; }

        }


        public abstract bool check();
        public abstract double cal();


        public String print(double salary)
        {
            String msg = "Hello," + fname+" " + lname + ".," +"This is  " + type + " Employee," + " YourSalary is: " + salary;

            return msg;
        }
        









    }
}
