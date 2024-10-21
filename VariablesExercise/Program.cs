namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Riley";
            int age = 18;
            double avg = 98.7;
            decimal hoursIngames = 2058.58m;
            char initial = 'S';
            bool likesLegos = true;

            Console.WriteLine($"Name: {myName}\nAge: {age}\nAverage: {avg}\nGame_Hours: {hoursIngames}\nInitial: {initial}\nLikes_Legos: {likesLegos}");
        }
    }
}