using System.Diagnostics;
using furbabystudent.Models;
using Microsoft.AspNetCore.Mvc;

namespace furbabystudent.Controllers
{
    public class HomeController : Controller
    {
    

        public IActionResult Index()
        {
            string studentname = "Silver";
            int age1= 3;
            string about1= "Smart, Brave, & Wicked";
            int score1 = 95;
            bool isPassed = (score1 >= 75);
            DateTime examdate = DateTime.Now;
            decimal tuitionfee = 2000.75m;
            string course1 = "Pet Training 101";
            int sessions1 = 4;
            decimal totalFee1 = tuitionfee * sessions1;
            decimal discount1 = totalFee1 * 0.10m;
            decimal NetFee1 = totalFee1 - discount1;

            ViewBag.StudentName = studentname;
            ViewBag.Age1 = age1;
            ViewBag.About1 = about1;
            ViewBag.Score = score1;
            ViewBag.Progress = isPassed;
            ViewBag.ExamDate = examdate;
            ViewBag.TFee = tuitionfee;
            ViewBag.Course = course1;
            ViewBag.Sessions = sessions1;
            ViewBag.Discount = discount1;
            ViewBag.TotalFee = totalFee1;
            ViewBag.NetFee1 = NetFee1;


            //score stat
            string grade1;
            string result1;

            if (score1 >= 90)
                grade1 = "Paw-Some!";
            else if (score1 >= 80)
                grade1 = "Pur-fectly fine!";
            else if (score1 >= 75)
                grade1 = "Slow but Paw-sitive.";
            else
                grade1 = "No Treats for Today.";

            result1 = isPassed
                ? "Fur-tastic! You passed the Petizen Exam!"
                : "Still purr-oud of you! but no treats today, keep trying pup!";

            ViewBag.Grade1 = grade1;
            ViewBag.Result1 = result1;

            //pet 2
            string studentname2 = "Shasha";
            int age2 = 2;
            string about2 = "Smart, Brave, & Wicked";
            int score2 = 85;
            bool isPassed2 = (score2 >= 75);
            DateTime examdate2 = DateTime.Now;
            decimal tuitionfee2 = 2000.75m;
            string course2 = "Pet Training 101";
            int sessions2 = 8;
            decimal totalFee2 = tuitionfee2 * sessions2;
            decimal discount2 = totalFee2 * 0.10m;
           
            decimal NetFee2 = totalFee2 - discount2;


            ViewBag.StudentName2 = studentname2;
            ViewBag.Age2 = age2;
            ViewBag.About2 = about2;
            ViewBag.Score2 = score2;
            ViewBag.Progress2 = isPassed2;
            ViewBag.ExamDate2 = examdate2;
            ViewBag.TFee2 = tuitionfee2;
            ViewBag.Course2 = course2;
            ViewBag.Sessions2 = sessions2;
            ViewBag.Discount2 = discount2;
            ViewBag.TotalFee2 = totalFee2;
            ViewBag.NetFee2 = NetFee2;

            //score stat
            string grade2;
            string result2;

            if (score2 >= 90)
                grade2 = "Paw-Some!";
            else if (score2 >= 80)
                grade2 = "Pur-fectly fine!";
            else if (score2 >= 75)
                grade2 = "Slow but Paw-sitive.";
            else
                grade2 = "No Treats for Today.";

            result2 = isPassed2
                ? "Fur-tastic! You passed the Petizen Exam!"
                : "Still purr-oud of you! but no treats today, keep trying pup!";

            ViewBag.Grade2 = grade2;
            ViewBag.Result2 = result2;

            //pet 3
            string studentname3 = "Ken";
            int age3 = 3;
            string about3 = "Crybaby, Chill, & Alert";
            int score3 = 93;
            bool isPassed3 = (score3 >= 75);
            DateTime examdate3 = DateTime.Now;
            decimal tuitionfee3 = 2000.75m;
            string course3 = "Pet Training 101";
            int sessions3 = 7;
            decimal totalFee3 = tuitionfee3 * sessions3;
            decimal discount3 = totalFee3 * 0.10m;
          
            decimal NetFee3 = totalFee3 - discount3;

            ViewBag.StudentName3 = studentname3;
            ViewBag.Age3 = age3;
            ViewBag.About3 = about3;
            ViewBag.Score3 = score3;
            ViewBag.Progress3 = isPassed3;
            ViewBag.ExamDate3 = examdate3;
            ViewBag.TFee3 = tuitionfee3;
            ViewBag.Course3 = course3;
            ViewBag.Sessions3 = sessions3;
            ViewBag.Discount3 = discount3;
            ViewBag.TotalFee3 = totalFee3;
            ViewBag.NetFee3 = NetFee3;

            //score stat
            string grade3;
            string result3;

            if (score3 >= 90)
                grade3 = "Paw-Some!";
            else if (score3 >= 80)
                grade3 = "Pur-fectly fine!";
            else if (score3 >= 75)
                grade3 = "Slow but Paw-sitive.";
            else
                grade3 = "No Treats for Today.";

            result3 = isPassed3
                ? "Fur-tastic! You passed the Petizen Exam!"
                : "Still purr-oud of you! but no treats today, keep trying pup!";

            ViewBag.Grade3 = grade3;
            ViewBag.Result3 = result3;


            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
