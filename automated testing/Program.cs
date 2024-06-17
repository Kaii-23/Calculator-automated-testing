namespace automated_testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class calculator
    {

        public calculator()
        {

        }
        public void menu(string option)
        {
            int abc;
            string Method;

            string userInput = OptionCheck("Choose from list:\n" +
                "1: Add\n" +
                "2: Subtract\n" +
                "3: Multiply\n" +
                "4: Divide\n",
                new string[] { "1 ", "2 ", "3", "4", });

            abc = int.Parse(userInput);
            string[,] number = { { "1", "2", "3", "4" }, { "add", "subtract", "multiply", "divide", } };
            Method = number[1, abc];

            Console.WriteLine($"choose two numbers that you would like to {Method}");

            Console.Write("Num1: ");
            int num1 = Console.Read();
            Console.WriteLine(" \n" +
                "Num2: ");
            int num2 = Console.Read();

            if (userInput == "1")
            {
                add(num1, num2);
            }
            static string OptionCheck(string message, string[] options)
            {
                string userInput = "";
                while (!options.Contains(userInput))
                {
                    userInput = PresenceCheck(message);
                }
                return userInput;
            }


            static string PresenceCheck(string message)
            {
                string userInput = "";
                while (userInput.Length == 0)
                {
                    Console.WriteLine(message);
                    userInput = Console.ReadLine();
                }
                return userInput;
            }
        }
        public int add(int num1, int num2)
        {
            int ans = num1 + num2;
            return ans;
        }
        public int sub(int num1, int num2)
        {
            int ans = num1 - num2;
            return ans;
        }
        public int mult(int num1, int num2)
        {
            int ans = num1 * num2;
            return ans;
        }
        public int div(int num1, int num2)
        {
            int ans = num1 / num2;
            return ans;
        }
    }
}