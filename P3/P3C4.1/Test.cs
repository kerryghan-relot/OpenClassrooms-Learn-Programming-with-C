namespace P3C4
{

    public class Test
    {
        // TODO: Create two test methods in here corresponding to the TryTest methods with the proper naming
        // 
        public static void TestSum()
        {
            if (Program.DoSum(1, 5) == 6)
            {
                Console.WriteLine("Sum works Ok");
            }
            else
            {
                Console.WriteLine("Sum doesn't work");
            }
        }

        public static void TestSub()
        {
            if (Program.DoSubtraction(10, 8) == 2)
            {
                Console.WriteLine("Sub works Ok");
            }
            else
            {
                Console.WriteLine("Sub doesn't work");
            }
        }
    }
}
