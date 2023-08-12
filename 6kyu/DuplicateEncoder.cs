using System;
public class Kata
{
  public static string DuplicateEncode(string word)
  {
    string encodedWord = "";
    word = word.ToLower();
    for(int i = 0 ; i < word.Length ; i++)
    {   int counter = 1 ;
        for (int j = 0 ; j<word.Length ;j++)
        {
           if(j != i && (word[i] == word[j] ))
           {
            counter++;
           }
        }
        if(counter == 1 )
        {
            encodedWord = encodedWord+ "(";
        }
        else
        {
            encodedWord = encodedWord+ ")";
            
        }
    }
    return encodedWord;
  }
}