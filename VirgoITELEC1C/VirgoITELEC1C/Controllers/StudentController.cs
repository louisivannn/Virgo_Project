using Microsoft.AspNetCore.Mvc;
using VirgoITELEC1C.Models;

namespace VirgoITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult Index()
        {
            Student st = new Student();
            st.StudentId = 1;
            st.StudentName = "Louis Ivan Virgo";
            st.DateEnrolled = DateTime.Parse("30/8/2023");
            st.StudentCourse = Course.BSIT;
            st.Email = "louisivan.virgo.cics@ust.edu.ph";
            ViewBag.Student = st;
            return View();
        }
    }
}
