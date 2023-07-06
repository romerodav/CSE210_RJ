public class Goals
{
    private List<Goal> _goals;

    private int _points = 0;

    private string _fileName = "";

    private Simple _simple;
    private Eternal _eternal;
    private Check _check;

    public Goals()
    {
        _goals = new List<Goal>();
    }

    public Goals(Goal goal)
    {
        _goals = new List<Goal>();
        _goals.Add(goal);
    }

    public int GetPoints()
    {
        return _points;
    }

    public int Account()
    {
        return _goals.Count;
    }

    public void Create()
    {
        string opt, name, descript, aux;
        int reward, times, bonus;

        Console.WriteLine("The types of Goals are:\n1-Simple Goal\n2-Eternal Goal\n3-CheckList Goal");

        do
        {
            Console.Write("Which type of goal would you like to create? ");
            opt = Console.ReadLine();
            opt = opt.Trim();
        }while(opt != "1" & opt != "2" & opt != "3");

        do
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            name = name.Trim();
        }while(name == "");

        do
        {
            Console.Write("What is a short description of it? ");
            descript = Console.ReadLine();
            descript = descript.Trim();
        }while(descript == "");

        do
        {
            do
            {
                Console.Write("What is the amount of points associated with this goal? ");
                aux = Console.ReadLine();
                aux = aux.Trim();
            }while(aux == "");
            reward = int.Parse(aux);
        }while(reward <= 0);

        if(opt == "3")
        {
            do
            {
                do
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    aux = Console.ReadLine();
                    aux = aux.Trim();
                }while(aux == "");
                times = int.Parse(aux);
            }while(times <= 0);

            do
            {
                do
                {
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    aux = Console.ReadLine();
                    aux = aux.Trim();
                }while(aux == "");
                bonus = int.Parse(aux);
            }while(bonus <= 0);

            _check = new Check(name, descript, reward, times, bonus);
            _goals.Add(_check);
        }
        else
        {
            if(opt == "2")
            {
                _eternal = new Eternal(name, descript, reward);
                _goals.Add(_eternal);
            }
            else
            {
                _simple = new Simple(name, descript, reward);
                _goals.Add(_simple);
            }
        }
    }

    public void List()
    {
        int i = 0;

        Console.WriteLine("The goals are:");
        foreach(Goal goal in _goals)
        {
            Console.Write($"{i+1}-");
            goal.Show();
            i++;
        }
    }

    public void FileName()
    {
        _fileName = "";
        while (_fileName == "")
        {
            Console.Write("What is the file name? ");
            _fileName = Console.ReadLine();
            _fileName = _fileName.Trim();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine($"Saving to {_fileName}");
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{_points}");
            foreach(Goal goal in _goals) outputFile.WriteLine($"{goal.ToFile()}");
        }
    }

    public void ReadFromFile()
    {
        Console.WriteLine($"Reading List from {_fileName}");
    	int i, points = 0;
        Simple simple;
        Eternal eternal;
        Check check;
        List<Goal> goals = new List<Goal>();

        string[] lines = System.IO.File.ReadAllLines(_fileName);
	    points = int.Parse(lines[0].Trim());

        foreach(string line in lines)
        {
            // Console.WriteLine(Line); // Just as it is recorded in the text file
            if(line != lines[0])
            {
                string[] part = line.Split(":");
                string[] field = part[1].Split(",");
                if(part[0] == "CheckListGoal")
                {
                    if(field[4] == field[5]) i = 1;
                    else i = 0;
                    check = new Check(field[0],field[1],int.Parse(field[2]),int.Parse(field[4]),int.Parse(field[3]),int.Parse(field[5]),i);
                    goals.Add(check);
                }
                else
                {
                    if(part[0] == "EternalGoal")
                    {
                        eternal = new Eternal(field[0],field[1],int.Parse(field[2]));
                        goals.Add(eternal);
                    }
                    else
                    {
                        if(field[3] == "False") i = 0;
                        else i = 1;
                        simple = new Simple(field[0],field[1],int.Parse(field[2]),0,0,0,i);
                        goals.Add(simple);
                    }
                }
            }
        }
        _goals.AddRange(goals);
        _points += points;
    }

    public void RecordEvent()
    {
        string aux;
        int i, SubT;

        do
        {
            do
            {
                Console.Write("Which goal did you accomplish? ");
                aux = Console.ReadLine();
                aux = aux.Trim();
            }while(aux == "");
            i = int.Parse(aux);
        }while(i <= 0 | i > _goals.Count);

        SubT = _goals[i-1].Event();
        if(SubT == 0) Console.WriteLine("This goal is already accomplished, please choose another or create a new one");
        else
        {
            _points += SubT;
            Console.WriteLine($"Congratulations! You won {SubT} points this time and have {_points} points now");
        }
    }

}