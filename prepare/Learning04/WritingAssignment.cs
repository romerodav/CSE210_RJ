public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment() : base()
    {
    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"Title: {_title} by {GetStudentName()}";
    }
}