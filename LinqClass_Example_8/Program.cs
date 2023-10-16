using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new
            {
                FirstName = "John",
                LastName = "Doe",
                Salary = 7456.32
            };
            WriteLine($"String: {worker}");
            WriteLine($"Type: {worker.GetType()}");
            WriteLine($"Hash code: {worker.GetHashCode()}");
        }
    }
}