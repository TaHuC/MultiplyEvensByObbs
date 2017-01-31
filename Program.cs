using System;

namespace MultiplyEvensByObbs
{
	class MainClass
	{
		public static void Main()
		{
			int inputNum = Math.Abs(int.Parse(Console.ReadLine()));

			int sum = GetMultipleOfEvensAndOdds(inputNum);

			Console.WriteLine(sum);
		}

		public static int GetMultipleOfEvensAndOdds(int value)
		{
			int sumOdds = GetSumOfOdd(value);
			int sumEvent = GetSumOfEvens(value);

			return sumOdds * sumEvent;
		}

		public static int GetSumOfOdd(int value)
		{
			int sum = 0;
			while (value > 0)
			{
				int lastDigit = value % 10;
				if (lastDigit % 2 != 0)
				{
					sum += lastDigit;
				}

				value /= 10;
			}
			return sum;
		}

		public static int GetSumOfEvens(int value)
		{
			int sum = 0;
			while (value > 0)
			{
				int lastDigit = value % 10;
				if (lastDigit % 2 == 0)
				{
					sum += lastDigit;
				}
				value /= 10;
			}
			return sum;
		}
	}
}
