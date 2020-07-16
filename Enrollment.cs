namespace SkoleniUtils
{
    public class Enrollment
    {
        public int Id  { get; set; }
        public int CourseId  { get; set; }
        public int StudentId  { get; set; }
        
        public virtual Course Course { get; set; }
        public virtual Student Student  { get; set; }
    }
}