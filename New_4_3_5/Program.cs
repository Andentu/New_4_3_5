namespace New_4_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Your name: " + name);

            // цикл для вывода посимвольно переменной name (with for):
            Console.Write("\nYour name by symbols (for): ");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine("\nПервая буква вашего имени {0}", name[0]);

            // цикл для вывода посимвольно переменной name (with foreach):
            Console.Write("\nYour name by symbols (foreach): ");
            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine("\nПоследняя буква вашего имени: {0}", name[name.Length - 1]);

            // Task 4.3.7
            //for
            Console.Write("\nYour name letter by letter in reverse order (for): ");
            for (int i = name.Length - 1; i != -1; i--) // Условие в уроке i >= 0
            {
                Console.Write(name[i] + " ");
            }

            Console.ReadKey(); 


        }
    }
}