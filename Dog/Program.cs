

internal class Program
{
    private static void Main(string[] args)
    {
        double firstSpeed = 200, secondSpeed = 300, dogspeed = 700;
        int count = 0, friend = 2;
        double distance = 20000, time = 0;

        while (distance > 10)
        {
            if (friend == 1)
            {
                time = distance / (firstSpeed + dogspeed);
                friend = 2;

            }
            else
            {
                time = distance / (secondSpeed + dogspeed);
                friend = 1;
            }
            distance = distance - time * (firstSpeed + secondSpeed);
            count += 1;
        }
        Console.Write("Собака пробeжит ");
        Console.Write(count);
        Console.Write(" раз");
    }
}