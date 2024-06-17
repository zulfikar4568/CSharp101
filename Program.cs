// 1. String

string firstName = "Zulfikar";
string lastName = "Isnaen";

Console.WriteLine($"My firstname is {firstName} and my lastname is {lastName}");

firstName = "                    Zulfikar                    ";
lastName = "                    Isnaen                    ";

string completeSentence = $"My firstname is {firstName.Trim()} and my lastname is {lastName.Trim()}";
Console.WriteLine(completeSentence);
Console.WriteLine(completeSentence.Replace("Zulfikar", "Abdul"));
Console.WriteLine(completeSentence.ToUpper());
Console.WriteLine(completeSentence.StartsWith("Zulfikar"));
Console.WriteLine(completeSentence.StartsWith("My "));
Console.WriteLine(completeSentence.EndsWith("en"));