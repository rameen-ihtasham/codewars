using System;

public class Persist
{
	public static int Persistence(long n)
	{
		int counter = 0;

		string num = n.ToString();

		while (num.Length != 1)
		{
			n = 1;
			for (int i = 0; i < num.Length; i++)
			{
				n = n * int.Parse(num[i].ToString());

			}
			counter++;
			num = n.ToString();
		}
		return counter;
	}
}