
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace A2_n11421860;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Simple Drawing Editor!");

        List<Shape> shapes = new List<Shape>();
        Canvas canvas = new Canvas();
        Menu mainMenu = new("", "Main menu");
        mainMenu.Add(new NewMenuItem("New", "Create new drawing", canvas, shapes));
        mainMenu.Add(new MenuItem("Open", "Open existing drawing"));
        mainMenu.Add(new EditMenu("Edit", "Edit drawing", shapes, canvas));
        mainMenu.Add(new MenuItem("Save", "Save drawing"));
        mainMenu.Add(new MenuItem("Save as", "Save drawing as ..."));
        mainMenu.Add(new MenuItem("Close", "Exit from system"));

        mainMenu.Action();

        Console.WriteLine();
        Console.WriteLine("Goodbye and thank you for using our service.");
    }
}