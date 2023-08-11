public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        string num = "";
        string firstthree = "";
        string midthree = "";
        string lastfour = "";
        for (int i = 0; i < 10; i++)
        {
            if (i < 3)
            {
                firstthree = firstthree + numbers[i];
            }
            else if (i < 6)
            {
                midthree = midthree + numbers[i];
            }
            else if (i < 10)
            {
                lastfour = lastfour + numbers[i];
            }
        }
        num = "(" + firstthree + ") " + midthree + "-" + lastfour;
        return num;

    }

}