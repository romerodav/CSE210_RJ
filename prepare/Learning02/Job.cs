// A code template for the category of things known as Job. The responsibility
//  of a Job is to Keeps track of the company, job title, start year, and end year
public class Job
{
    // The C# convention is to start member variables with an underscore _
    public string _company = "", _jobTitle = "";
    public int _startYear = 0, _endYear = 0;

    // A special method, called a constructor that is invoked using  
    // the new keyword followed by the class name and parentheses
    public Job()
    {
    }

    // A method that displays the job information in the format
    // "Job Title (Company) StartYear-EndYear"
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}