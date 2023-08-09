public class Kata
{
  public static string Smash(string[] words)
  {
    string sentence = "";
    for(int i = 0; i < words.Length; i++)
    {
      if(i != words.Length - 1)
      {
       sentence = sentence + words[i] + " ";
      }
      else
      {
       sentence = sentence + words[i];
      }     
    }
    return sentence;
  }
}