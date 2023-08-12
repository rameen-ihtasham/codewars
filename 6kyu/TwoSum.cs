public class Kata
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        int[] indexes = new int[2];
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if ((numbers[i] + numbers[j] == target) && i != j)
                {
                    indexes[0] = i;
                    indexes[1] = j;
                    return indexes;
                }
            }
        }
        return indexes;
    }
}