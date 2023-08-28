
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            string upperCase = s[i].ToString().ToUpper();
            if (dictionary.ContainsKey(s[i]) || dictionary.ContainsKey((char.Parse(upperCase))))
            {
                dictionary[s[i]]++;
            }
            else
            {
                dictionary.Add(s[i], 1);
            }
        }
        int value = 1;
        char key = dictionary.FirstOrDefault(pair => pair.Value == value).Key;
        if (key == '\0')
        {
            return "";
        }
        else
        {
            return key.ToString();
        }



    }
}