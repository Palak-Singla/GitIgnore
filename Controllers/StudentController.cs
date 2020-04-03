using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gitIgnoreEx.Models;
using Microsoft.AspNetCore.Mvc;

namespace gitIgnoreEx.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> objstu = new List<Student>()
            {
                new Student{SId=1,SName="Palak",SRollNo=101},
                new Student{SId=2,SName="Kareena",SRollNo=102},
                new Student{SId=3,SName="Pushp",SRollNo=103}
            };
            return View(objstu);
        }
    }
}