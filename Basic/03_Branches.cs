namespace LearnCSharp.Basic
{
  class Branches
  {
    static void Execute()
    {
      int a = 2;
      int b = 5;

      // single-line if statements
      if (a + b > 10)
        Console.WriteLine("a value plus b value greater than 10");
      else
        Console.WriteLine("a value plus b value less than 10");

      // multi line if statements
      int c = 4;
      if ((a + b + c > 10) && (a == b))
      {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is equal to the second");
      }
      else
      {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not equal to the second");
      }
    }
  }
}