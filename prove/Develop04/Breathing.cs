public class Breathing : Activity
{
    /*public Breathing(): base()
    {
    }*/

    public Breathing(string welcome = "Welcome to the Breathing Activity!", string description = "This activity will help you relax by walking your through breathing in and out slowly. Please clear your mind and focus on your breathing", string ending = "Breathing", int duration = 0): base(welcome, description, ending, duration)
    {
    }

    public void BreathRun()
    {
        DateTime startTime = DateTime.Now, endTime = startTime.AddSeconds(GetDuration());
        int i = 0, ban = 0;

        while(DateTime.Now < endTime)
        {
            if(ban == 0)
            {
                Console.Write("Breath in...");
                if(i <= 4)
                {
                    Console.Write($"{4-i}");
                    Thread.Sleep(1000);
                    Console.Write("\r \r");
                    i++;
                }
                else
                {
                    ban = 1;
                    i = 0;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("Now breath out...");
                if(i <= 6)
                {
                    Console.Write($"{6-i}");
                    Thread.Sleep(1000);
                    Console.Write("\r \r");
                    i++;
                }
                else
                {
                    ban = 0;
                    i = 0;
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine();
    }
}