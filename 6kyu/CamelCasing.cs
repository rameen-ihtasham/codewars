public class Kata
{
  public static string BreakCamelCase(string str)
  {
    string camelCased = "";
    for(int i = 0 ; i < str.Length ; i++)
    {
        string uppercased = str[i].ToString();
        if(str[i].ToString() == uppercased.ToUpper())
        {
            camelCased = camelCased + " " + str[i];
        }
        else
        {
            camelCased = camelCased + str[i];
        }
    }
    return camelCased;
  }
}