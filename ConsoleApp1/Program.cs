string userPin;

while (true)
{
    Console.WriteLine("Enter your PIN");
    userPin = Console.ReadLine();
    if(userPin == "1234")
    {
        Console.WriteLine("Welcome!");
        break;
    }
    else
    {
        Console.WriteLine("Wrong PIN. Try again.");
    }
}