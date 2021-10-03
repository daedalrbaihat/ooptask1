using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using oopt1.Models;

namespace oopt1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View("empview");
        }

        public IActionResult Index1()
        {
            var select = Request.Form["select"];

            if (select == "Hourly")
            {
                HourlyEm h = new HourlyEm();
                h._fname = Request.Form["textfname"];
                h._lname = Request.Form["textlname"];
                h._email = Request.Form["textemail"];
                h._phone = Request.Form["textphone"];
                h._taybe = Request.Form["select"];
                h._hours = Convert.ToInt32(Request.Form["texthour"]);
                h._hourprice = Convert.ToDouble(Request.Form["texthp"]);



                bool isvalid = h.check();
                h.cal();
                if (isvalid == true)
                {
                    double salary = h.cal();
                    String msg = h.print(salary);
                    ViewData["message"] = msg;


                }

            }
            else
            {
                FullEm f = new FullEm();

                f._fname = Request.Form["textfname"];
                f._lname = Request.Form["textlname"];
                f._email = Request.Form["textemail"];
                f._phone = Request.Form["textphone"];
                f._taybe = Request.Form["select"];
               f._day= Convert.ToInt32(Request.Form["textday"]);
               f._dayrice = Convert.ToDouble(Request.Form["textdp"]);



                bool isvalid = f.check();
                f.cal();
                if (isvalid == true)
                {
                    double salary = f.cal();
                    String msg = f.print(salary);
                    ViewData["message"] = msg;


                }




            }


            return View("empview");





        }

    }
}
