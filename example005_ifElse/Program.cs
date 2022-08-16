Console.Write("введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("Hello, Maria! Glade to see you!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}