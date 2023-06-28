class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Please enter the hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Please enter the minutes : ");
            int minutes = int.Parse(Console.ReadLine());
            if (hours < 0 || minutes < 0)
            {
                Console.WriteLine("Please enter a positive number");
                Console.ReadKey();
            }
            else
            {
                while (hours > 12)
                {
                    hours -= 12;
                }

                while (minutes >= 60)
                {
                    minutes -= 60;
                    hours += 1;
                    if (hours > 12)
                    {
                        hours -= 12;
                    }
                }

                double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
                double minuteInDegrees = minutes * 6;
                double diff = Math.Abs(hourInDegrees - minuteInDegrees);
                diff = Math.Min(360 - diff, diff);

                Console.WriteLine($"The lesser angle between {hours} hours arrow and {minutes} minutes arrow is {diff} degrees");
                Console.ReadKey();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number");
            Console.ReadKey();
        }
    }
}
