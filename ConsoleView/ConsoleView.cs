namespace LAB2;

public class ConsoleView
{
    public static void Main(string[] args) => ShowMainView(new Note());

    public static void ShowMainView(Note? note)
    {
        Console.WriteLine("\nWELCOME TO CONSOLE APP! \n");
        Console.WriteLine(note?.Title);
        Console.WriteLine(note?.Content);
    }
}