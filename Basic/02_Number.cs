namespace LearnCSharp.Basic
{
  class Number
  {
    static public void Execute()
    {
      int a = 2147483647; // maximum 2147483647 until -2147483648
      int b = 2147483647;
      long c = a + b; // System.OverflowException!! store wrong value in long bucket
      long d = (long)a + (long)b;
      long e = checked(a + b); // check the overflow
      Console.WriteLine(c);
      Console.WriteLine(d);
      Console.WriteLine(e);

      float f = 30.3F;
      double g = 40.4;
      // double h = f + g; // 70.69999923706055
      float h = (float)g + f; // 70.7


      decimal i = 30.3M;
      decimal j = 40.4M;
      decimal k = i + j; // 70.7
      Console.WriteLine(k);
    }
  }
}

// Program.cs

//LearnCSharp.Basic.Number.Execute();