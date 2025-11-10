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

try
{
    Console.Write("Enter your password: ");
    string password = Console.ReadLine();

#pragma warning disable CS8602 // Dereference of a possibly null reference.
    if (password.Length < 6)
    {
        throw new Exception("Password must be at least 6 characters.");
    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

    Console.WriteLine("Password satisfied the requirement.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}