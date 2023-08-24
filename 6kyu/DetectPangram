using System;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    bool flag ; 
    string alphabets = "abcdefghijklmnopqrstuvwxyz";
    for(int i = 0 ; i < alphabets.Length ; i++)
    {
        flag = false;
        for(int j = 0 ; j < str.Length ; j++)
        {
            
            if(str[j] == alphabets[i] ||  (str[j].ToString()) == alphabets[i].ToString().ToUpper())
            {
               flag = true;
               break;
            }
        }
        if(flag == false)
        {
            return flag;
        }
    }
    return true;
    
  }
}