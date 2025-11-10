public class NullOperations
{
    public void PerformNullChecks()
    {
    
        string username = null;
        
        
        string result1 = (username == null) ? "Username is not available" : username;
        Console.WriteLine($"Ternary Operator: {result1}");
        
        string result2 = username ?? "Username is not available";
        Console.WriteLine($"Null-Coalescing Operator: {result2}");
        
        
        username ??= "DefaultUser";
        Console.WriteLine($"After Null-Coalescing Assignment: {username}");
    }
}