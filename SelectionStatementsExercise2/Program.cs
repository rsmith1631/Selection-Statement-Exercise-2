namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("What is your favorite school subject");
        string userSubject = Console.ReadLine();

        switch(userSubject.ToLower()) 
        {
            case "math":
                Console.WriteLine($"Math is a great subject");
                break;
            case "english":
                Console.WriteLine($"English is where it all begins");
                break;
            case "social studies":
                Console.WriteLine($"Social Studies is how we understand one another!");
                break;
            case "science":
                Console.WriteLine($"Science is where innovations happen!");
                break;
            case "spanish":
                Console.WriteLine($"It's always good to know a second language!");
                break;
            default:
                Console.WriteLine($"I wish you the best on your continued studies!");
                break;
        }
        }
    }
}