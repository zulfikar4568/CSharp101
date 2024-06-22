namespace LearnCSharp.Basic
{
  class Looping
  {
    static public void Execute()
    {
      int counter = 0;

      while (counter < 10)
      {
        Console.WriteLine($"The counter is {counter}");
        counter++;
      }

      counter = 0;
      do
      {
        Console.WriteLine($"The counter is {counter}");
        counter++;
      } while (counter < 10);


      for (int c = 0; c < 10; c++)
      {
        Console.WriteLine($"The counter is {c}");
      }
    }
  }
}