using System;
class pingpong
{
  static void Main()
{
  Console.WriteLine("Enter number");
  string yourNumber = Console.ReadLine();
  int number  = int.Parse(yourNumber);

  for(int i = 1; i <= number; i++ )
  {
    if (i%5 == 0 && i%3 == 0)
    {
      Console.WriteLine("Pingpong");
    } else if (i%3 == 0 )
    {
    Console.WriteLine("Pong");
  } else if (i%5 == 0) {
      Console.WriteLine("Ping");
    } else {
      Console.WriteLine(i);
    }
  }
  }
}
