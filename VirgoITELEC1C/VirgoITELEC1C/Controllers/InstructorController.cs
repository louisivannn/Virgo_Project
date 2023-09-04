using Microsoft.AspNetCore.Mvc;
using VirgoITELEC1C.Models;
namespace VirgoITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
        {
            new Instructor()
            {

                InstructorName= "Louis Ivan Virgo", DateHired= DateTime.Now,
                InstructorEmail= "louisivan.virgo.cics@ust.edu.ph", Rank= Rank.Instructor
            },
            new Instructor()
            {
                InstructorName="Leo Lintag", DateHired= DateTime.Parse("25/08/2000"),
                InstructorEmail="llintag@ust.edu.ph",Rank= Rank.AssistantProf
            }
        };
        public IActionResult Index()
        {

            return View(InstructorList);
        }
    }
}
