namespace COMP003B.LectureActivity6.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set;}

        // Nullable navigation properties
        public virtual Student? Student { get; set; }
        public virtual Course? Course { get; set; }

    }
}
