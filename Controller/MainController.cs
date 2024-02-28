namespace LAB2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose your mode: \n 1 - Console App; \n 2 - GUI App; 0 - exit.");

            var input = Console.ReadLine();

            switch (input) 
            {
                case "1":
                    StartWithConsoleApp();
                    break;

                case "2":
                    StartWithGuiApp();
                    break;

                case "0":
                    Environment.Exit(0);
                    break;

                default: Main(args);
                    break;
            }
        }

        public static void StartWithConsoleApp() => SimpleConsoleView.Main(new string[1]);

        public static void StartWithGuiApp() => AvaloniaView.Program.Main(new string[1]);
    }
}