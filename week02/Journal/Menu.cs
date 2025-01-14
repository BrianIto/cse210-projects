
public class Menu {
    public static void Welcome() {
        Console.WriteLine("Welcome to the Journal Program!");
    }
    public static uint Display() {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        uint option = uint.Parse(Console.ReadLine());
        return option;
    }
}