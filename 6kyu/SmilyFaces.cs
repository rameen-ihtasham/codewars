public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
    int smileyCount = 0 ;
     for(int i = 0 ; i < smileys.Length ; i++)
     {
            string ch = smileys[i];
        if(smileys[i].Length == 2 )
        {
            if((ch[0] == ':' || ch[0] == ';')&& (ch[1] == ')' || ch[1] == 'D') )
            {
                smileyCount++;
            }          

        }
        else if(smileys[i].Length == 3)
        {
        if((ch[0] == ':' || ch[0] == ';')&& (ch[1] == '-' || ch[1] == '~') && (ch[2] == ')' || ch[2] == 'D') )
            {
                smileyCount++;
            }  
        }
     }
     return smileyCount;
  }
}