using System;

class Program
{
    static void Main(string[] args)
    {
        

    
        {
            Console.Write("Enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum from 1 to " + N + " is: " + sum);
        }

        Console.WriteLine(); // Blank line for readability

    
        {
            int j = 1;

            while (j <= 20)
            {
                if (j % 4 == 0)
                {
                    j++;
                    continue; // Skip multiples of 4
                }

                if (j == 15)
                {
                    break; // Stop when number is 15
                }

                Console.WriteLine(j);
                j++;
            }
        }

        Console.WriteLine(); // Blank line for readability

    
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            Console.WriteLine("Sum of array elements: " + total);
        }

        Console.WriteLine(); // Blank line for readability

        // -------------------- TASK 6 : TRY-CATCH-FINALLY --------------------

    
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        Console.WriteLine(); // Blank line for readability

        // 2️⃣ Try-Catch with Throw - Password length check
        {
            try
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}