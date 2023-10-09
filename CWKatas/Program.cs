internal class Program
{
  Katas katas = new();

  private static void Main(string[] args)
  {

  }

  void Order()
  {
    string words = "Welcome";

    words = katas.Order(words);

    Console.WriteLine(words);
  }

  void SpinWords()
  {
    string sentence = "Welcome";

    sentence = katas.SpinWords(sentence);

    Console.WriteLine(sentence);
  }
}