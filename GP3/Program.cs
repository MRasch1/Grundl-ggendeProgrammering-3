namespace GrProg3_procent
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Procent regning af to tal");
            do
            {
                int[] inputArray = InputNumbers();
                double[] resultArray = CalculatePercentage(inputArray);
                ShowResults(inputArray, resultArray);
                Console.WriteLine("Wanna try again (Y/N)");
            }
            while (Console.ReadKey().Key == ConsoleKey.Y);
        }

        static int[]? InputNumbers()
        {
            Console.WriteLine("Input number 1");
            string? string1 = Console.ReadLine();
            bool didItFail1 = int.TryParse(string1, out int num1);

            Console.WriteLine("Input number 2");
            string? string2 = Console.ReadLine();
            bool didItFail2 = int.TryParse(string2, out int num2);
            
            if (didItFail1 == true && didItFail2 == true)
            {
                int[] inputArray = { num1, num2 };
                return inputArray;
            }
            return null;
        }


       static double[] CalculatePercentage(int[] inputArray)
        {
            int num1 = inputArray[0];
            int num2 = inputArray[1];
            double result1 = num1 * num2 / 100d;
            double result2 = (double)num2 * num1 / 100;
            double[] resultArray = { result1, result2 };
            return resultArray;
        }

        static void ShowResults(int[] iA, double[] rA)
        {
            Console.WriteLine($"{iA[0]}% of {iA[1]} equals {rA[0]}");
            Console.WriteLine($"{iA[1]}% of {iA[0]} equals {rA[1]}");
        }


    }
}