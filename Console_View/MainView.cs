using Models;

public class ConsoleView
{
    public ConsoleView(Note note) => ShowMainView(note);

    public void ShowMainView(Note note)
    {
        Console.BackgroundColor = ConsoleColor.White;

        Console.WriteLine("WELCOME TO CONSOLE APP! \n\n", ConsoleColor.Yellow);
        Console.WriteLine("I have a note for you! \n");
        Console.WriteLine(note.Title, ConsoleColor.DarkGreen);
        Console.WriteLine(note.Content, ConsoleColor.Green);
    }
}