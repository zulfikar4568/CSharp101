namespace LearnCSharp.Basic
{
  class Collection
  {
    static public void Execute()
    {
      var names = new List<string> { "Alice", "Bob", "Jax" };

      foreach (var name in names)
      {
        Console.WriteLine($"My name is {name}");
      }

      names.Add("Chips");
      names.Remove("Empty");
      names.Remove("Alice");
      names.RemoveAt(2);

      for (int i = 0; i < names.Count; i++)
      {
        Console.WriteLine($"My name is {names[i].ToUpper()}");
      }

      // Console.WriteLine(names[100]);  // System.ArgumentOutOfRangeException: Index was out of range.
      Console.WriteLine(names[names.Count - 1]); // last array
      Console.WriteLine(names[^1]); // last array

      // Notes: Array typically when we want to use fix memory, but for dynamic it might be better use List
      var arrayNames = new string[] { "Alice", "Bob", "Jax" };
      arrayNames = [.. arrayNames, "Zulfikar"];


      /*Indexing and Sort*/
      var numbers = new List<int> { 44, 45, 76, 34, 12, 88 };

      Console.WriteLine($"I found 45 at index of: {numbers.IndexOf(45)}");
      numbers.Sort();
      Console.WriteLine($"I found 45 at index of: {numbers.IndexOf(45)}");
    }
  }
}

// Program.cs

//LearnCSharp.Basic.Collection.Execute();