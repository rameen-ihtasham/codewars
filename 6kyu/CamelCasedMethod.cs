namespace Kata
{
    public static class Problem
    {
        public static string CamelCase(this string str)
        {
               string camelCased = "";
            string[] arr = str.Split(' ');
            for(int i = 0  ; i < arr.Length; i++) {
                string word = arr[i];
                for(int j = 0; j< word.Length; j++)
                {
                    if(j== 0 )
                    {
                        camelCased += word[j].ToString().ToUpper();
                    }
                    else
                    {
                        camelCased += word[j];
                    }
                }
               
            }
            return camelCased;

        }
    }
}