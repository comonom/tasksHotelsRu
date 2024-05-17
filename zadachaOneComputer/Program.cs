namespace zadachaOneComputer
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static string CaseOfComputer(int number)
        {
            string result = $"{number} компьютер";
            int lastNum = number % 10;
            int lastTwoNum = number % 100;

            if (lastTwoNum >= 11 && lastTwoNum <= 14
                || lastNum >= 5 && lastNum <= 9
                || lastNum == 0)
            {
                result += "ов";
            }
            else if (lastNum >= 2 && lastNum <= 4)
            {
                result += "а";
            }

            return result;

        }

        public static int[] CommonDivisors(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 2; i <= nums.Min(); i++)
            {
                bool needAdd = true;
                foreach (int num in nums)
                {
                    if (num % i != 0)
                    {
                        needAdd = false;
                        break;
                    }
                }
                if (needAdd)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }

        public static int[] SimpleNums(int min, int max)
        {
            List<int> result = new List<int>();
            for (int i = 2; i <= max; i++)
            {
                bool needAdd = true;
                foreach (int j in result)
                {
                    if (j > Math.Sqrt(i) + 1)
                    {
                        break;
                    }
                    if (i % j == 0)
                    {
                        needAdd = false;
                        break;
                    }
                }
                if (needAdd)
                {
                    result.Add(i);
                }
            }

            for (int i = 2; i < min; i++)
            {
                result.Remove(i);
            }

            return result.ToArray();
        }

        public static void MultiplicationTable(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"\t{i}");
            }

            Console.WriteLine();

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j <= num; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
