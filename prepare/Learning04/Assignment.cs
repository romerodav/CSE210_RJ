public class Assignment
{
    private string _studentName, _topic;

    public Assignment()
    {
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"Student Name: {_studentName} - Topic: {_topic}";
    }
}