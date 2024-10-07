
//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"i equals {i + 1}");
//}

//for (int i = 10; i > 0; i--) //i-- = i - 1
//{
//    Console.WriteLine($"i equals {i}");
//}


int sum = 0;

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"i equals {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i;  //sum += i;
}

Console.WriteLine($"Final total {sum}");