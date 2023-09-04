namespace VirgoITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProf, Prof
    }
    public class Instructor
    {
       public int InstructorID { get; set; }
        public string InstructorName { get; set;}
        public string InstructorEmail { get; set;}

        public DateTime DateHired { get; set;}
        public Rank Rank { get; set;}
    }
}
