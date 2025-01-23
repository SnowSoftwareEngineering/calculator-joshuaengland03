namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Welcome to the calculator project, complete the methods

            // Call the methods here ex.
            int result = Add(2, 3);
            int result2 = Subtract(2, 3);
            int result3 = Multiply(2, 3);
            Console.WriteLine("The result of adding 2 and 3 is: " + result);
            Console.WriteLine("The result of subtracting 2 and 3 is: " + result2);
            Console.WriteLine("The result of multiplying 2 and 3 is: " + result3);
        }


        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }
        public static int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }
        public static decimal Divide(int a, int b)
        {
            int result = a / b;
            return result;
        }
    }
}
