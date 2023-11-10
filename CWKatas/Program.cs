internal class Program
{
  Katas katas = new();

  public static void Main(string[] args)
  {
    Program program = new Program();
    program.Run();
  }

  void Run()
  {
    Order();
  }

  void Order()
  {
    string words = "is2 Thi1s T4est 3a";

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