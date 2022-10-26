public class Kata_V1
{
    public static string Smash(string[] words)
    {
        string new_str = string.Empty;
        for (int i = 0; i < words.Length; i++)
        {
            new_str += words[i];
            if (i != words.Length - 1 && words.Length != 1)
                new_str += " ";
        }
        return new_str;
    }
}

//  HOWEVER!!!
// SIPLY

public class Kata_V2
{
    public static string Smash(string[] words) => String.Join(" ", words);
}