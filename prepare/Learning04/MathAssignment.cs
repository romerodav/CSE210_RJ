public class MathAssignment : Assignment
{
    private string _textbookSection, _problems;

    public MathAssignment() : base()
    {
    }

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Textbook section: {_textbookSection} - Problems: {_problems}";
    }
}