
Random rnd = new Random();

int myRandomNum;

int randomSum = 0;  

for(int i = 0; i < 4; i++)
{
myRandomNum = rnd.Next(0, 200);  //0 - 10
    randomSum = randomSum + myRandomNum;
Console.WriteLine($"My random number is: {myRandomNum}");
}
Console.WriteLine($"Random sum total: {randomSum}");