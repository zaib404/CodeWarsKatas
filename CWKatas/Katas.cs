public class Katas
{
    public Katas()
    {

    }

    public string Order(string words)
    {
        // return if empty
        if (string.IsNullOrEmpty(words))
        {
            return words;
        }

        List<string> rtnWords = new List<string>();
        // split into list
        List<string> wordList = words.Split(' ').ToList();
        
        for (int i = 1; i <= wordList.Count; i++)
        {
            string stringNum = i.ToString();
            // covert to string find based on i
            string match = wordList.Find(x => x.Contains(stringNum));
            rtnWords.Add(match);
        }
        
        return string.Join(" ", rtnWords);
    }

    public string SpinWords(string sentence)
    {
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

        return string.Join(" ", rtnList);
    }

}