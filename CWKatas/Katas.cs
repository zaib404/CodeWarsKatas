public class Katas
{
    public Katas()
    {

    }

    public string Order(string words)
    {
        string rtnWords = "";
        
        return rtnWords;
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