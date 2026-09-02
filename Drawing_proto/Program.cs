using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace Drawing_proto;

/// <summary>
/// Entry point for the Drawing Editor prototype application.
/// </summary>
public class Program
{
    /// <summary>
    /// Creates the drawing, canvas, and main menu.
    /// </summary>
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Simple Drawing Editor!");

        // Keep the shape collection and canvas shared between menu commands so every
        // operation works with the current drawing.
        List<Shape> shapes = new List<Shape>();
        Canvas canvas = new Canvas();
        Menu mainMenu = new("", "Main menu");
        mainMenu.Add(new NewMenuItem("New", "Create new drawing", canvas, shapes));
        mainMenu.Add(new MenuItem("Open", "Open existing drawing"));
        mainMenu.Add(new EditMenu("Edit", "Edit drawing", shapes, canvas));
        mainMenu.Add(new MenuItem("Save", "Save drawing"));
        mainMenu.Add(new MenuItem("Save as", "Save drawing as ..."));
        mainMenu.Add(new MenuItem("Close", "Exit from system"));

        // Start the main menu. It remains active until the user chooses "Close".
        mainMenu.Action();

        Console.WriteLine();
        Console.WriteLine("Goodbye and thank you for using our service.");
    }
}