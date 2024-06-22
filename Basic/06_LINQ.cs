namespace LearnCSharp.Basic
{
  class LINQ
  {
    static public void Execute()
    {
      List<int> scores = [67, 89, 78, 85, 55, 103, 88, 45, 25, 68];

      // using LINQ
      IEnumerable<int> queryScores =
        from score in scores
        where score > 60
        orderby score descending
        select score;

      // using LINQ
      int highestScoreCount = (from score in scores where score > 60 select score).Count();

      Console.WriteLine($"The total high score is {highestScoreCount}");

      foreach (int score in queryScores)
      {
        Console.Write(score + " ");
      }

      // using LINQ
      IEnumerable<string> queryScores2 =
        from score in scores // required
        where score > 60 // optional
        orderby score descending // optional
        select $"The score is {score}"; // required

      foreach (string score in queryScores2.ToList<string>())
      {
        Console.WriteLine(score);
      }

      // using Query
      var queryScores3 = scores
        .Where(s => s > 60)
        .OrderByDescending(s => s);

      foreach (int score in queryScores3)
      {
        Console.Write(score + " ");
      }
    }
  }
}

// Program.cs

//LearnCSharp.Basic.LINQ.Execute();