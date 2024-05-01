namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyExercises();

            int added = Addition(2, 2);
            Console.WriteLine(added);

            int subtracted = Subtraction(5, 2);
            Console.WriteLine(subtracted);

            int multiplied = Multiplication(4, 2);
            Console.WriteLine(multiplied);

            int divided = Division(10, 2);
            Console.WriteLine(divided);
        }


        static void MyExercises()
        {
            // Exercise One
            Console.WriteLine("Hello, what is your name?: ");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?: ");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite Animal?: ");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?: ");
            string band = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine($"name = {name}");
            Console.WriteLine($"color = {color}");
            Console.WriteLine($"animal = {animal}");
            Console.WriteLine($"band = {band}");

            Console.WriteLine("");
            Console.WriteLine($"{name} A lover of {color} color, kept a {animal}. They jammed to the {band} every weekend.");

        }

        public static int Addition(int num1, int num2)
        {
             
            return num1 + num2;
        }

        public static int Subtraction(int num1, int num2)
        {

            return num1 - num2;
        }

        public static int Multiplication(int num1, int num2)
        {

            return num1 * num2;
        }
        public static int Division(int num1, int num2)
        {

            return num1 / num2;
        }

    }
}
