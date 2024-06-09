using System;

class Program
{
    static void Main()
    {
        // Request first number
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        // Request second number
        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        // Handle conversion/division
        try
        {
            // Convert first input
            int num1 = Convert.ToInt32(input1);
            // Convert second input
            int num2 = Convert.ToInt32(input2);

            // Calculate division
            int result = Divide(num1, num2);
            // Display result
            Console.WriteLine($"The result is: {result}");
        }
        // Format exception catch
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integers.");
        }
        // Zero division catch
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        // Generic exception catch
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    // Perform division
    static int Divide(int numerator, int denominator)
    {
        // Return quotient
        return numerator / denominator;
    }
}