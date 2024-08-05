namespace P3C4
{
    public class Program
    {
        // TODO: Create two methods
        public static int DoSubtraction(int a, int b)
        {
            return a - b;
        }
        public static int DoSum(int a, int b) => a + b;

        static void Main(string[] args)
        {
            // TODO: Print the output of these two methods in main
            Console.WriteLine($"Output of the sum of 5 and 3: {DoSum(5, 3)}");
            Console.WriteLine($"Output of the subtraction of 5 and 3: {DoSubtraction(5, 3)}");
            // TODO: Run the test methods for the two methods in the TryTest class
            Test.TestSub();
            Test.TestSum();
        }

    }

}