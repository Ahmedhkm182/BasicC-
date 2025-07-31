namespace session2
{


    class SimpleCalculator
    {
        static void Main()
        {
            Console.WriteLine("Hello!");

            Console.Write("Input the first number: ");
            string input1 = Console.ReadLine();
            if (!double.TryParse(input1, out double num1))
            {
                Console.WriteLine("Invalid number. Exiting...");
                return;
            }

            Console.Write("Input the second number: ");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double num2))
            {
                Console.WriteLine("Invalid number. Exiting...");
                return;
            }

            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine()?.Trim().ToUpper();

            switch (choice)
            {
                case "A":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "S":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "M":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }

}
