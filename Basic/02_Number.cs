namespace LearnCSharp.Basic
{
  class Number
  {
    static void Execute()
    {
      int a = 2147483647; // maximum 2147483647 until -2147483648
      int b = 2147483647;
      long c = a + b; // System.OverflowException!! store wrong value in long bucket
      long d = (long)a + (long)b;
      // long e = checked(a + b); // check the overflow
      Console.WriteLine(c);
      Console.WriteLine(d);
      // Console.WriteLine(e);
    }
  }
}