public class Number
{
    public static int DigitalRoot(long n)
    {
        string number = n.ToString();
        int num = 0;

        while (number.Length != 1)
        {
            num = 0;
            for (int i = 0; i < number.Length; i++)
            {
                num = num + int.Parse(number[i].ToString());
            }
            number = num.ToString();

        }
        return num;

    }
}