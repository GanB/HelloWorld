namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) { Console.WriteLine("Howdy Y'all!!"); }
            else
            {
                switch (args[0].ToLower())
                {
                    case "formal":
                        Console.WriteLine("Hello, How are you?");
                        break;
                    case "casual":
                        Console.WriteLine("Hey, What’s up?");
                        break;
                    default:
                        Console.WriteLine("Howdy Y'all!!");
                        break;
                }
            }

            Console.ReadKey();

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                if (animal.Length >= 5)
                    Console.WriteLine(animal);
            }


        }
    }
}