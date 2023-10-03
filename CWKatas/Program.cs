// See https://aka.ms/new-console-template for more information


string sentence = "Welcome";

List<string> rtnList = sentence.Split(' ').ToList();
    
    for (int i = 0; i < rtnList.Count; i++)
    {
      if (rtnList[i].Count() >= 5)
      {
        string rev = "";
        
        for (int j = rtnList[i].Length - 1; j >= 0; j--)
        {
          rev += rtnList[i][j];
        }
        
        if (rev.Length >= 5)
        {
          rtnList[i] = rev;
        }
      }
    }
    sentence = string.Join(" ", rtnList);

Console.WriteLine(sentence);