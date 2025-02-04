namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            int loop;
            do
            {
                Console.WriteLine("Select your choice of operation:\n1. Addition\n2. Subtraction" +
                    "\n3. Multiplication\n4. Division\n5. Cancel/Close\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 5)
                {
                    Console.WriteLine("QUITTING");
                    Environment.Exit(0);
                }
                Console.WriteLine("Enter number 1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1: cal.Addition(num1, num2); break;
                    case 2: cal.Subtraction(num1, num2); break;
                    case 3: cal.Multiplication(num1, num2); break;
                    case 4: cal.Divide(num1, num2); break;
                    default: Console.WriteLine("Invalid choice!! Try again"); break;
                }
                Console.WriteLine("\n\nWould you like to try again?\n1. Enter any number to try again\n" +
                    "2. Enter -1 to quit");
                loop = Convert.ToInt32(Console.ReadLine());
            } while (loop != -1);
            Console.WriteLine("QUITTING");
            Console.ReadKey();
        }
    }
}
