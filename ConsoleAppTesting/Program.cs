namespace ConsoleAppTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var calculatorTests = new CalculatorTests();

            Console.WriteLine("Running tests");

            try
            {
                calculatorTests.MultiplyTest();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error running test: {ex.Message}");
            }
        }
    }
}