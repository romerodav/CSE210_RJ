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
        int i = 0, ban = 0, breathIn = 4, breathOut = 6, pace =1000;

        while(DateTime.Now < endTime)
        {
            if(ban == 0)
            {
                Console.Write("Breath in...");
                if(i <= breathIn)
                {
                    if(i < breathIn) Console.Write($"{breathIn-i}");
                    else Console.Write(" ");
                    Thread.Sleep(pace);
                    Console.Write("\r");
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
                if(i <= breathOut)
                {
                    if(i < breathOut) Console.Write($"Now breath out...{breathOut-i}");
                    else Console.Write("Now breath out... ");
                    Thread.Sleep(pace);
                    if(i < breathOut) Console.Write("\r");
                    i++;
                    if(i > breathOut) Console.WriteLine();
                }
                else
                {
                    ban = 0;
                    i = 0;
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine("\n");
    }
}