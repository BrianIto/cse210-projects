using System;

// Exceeding Requirements:
//
// It saves the data as a JSON as specified in the class of Entry.
// Also, it shows a confirm action to Load Data, that any unsaved data will be lost.
//
// Learned how to serialize JSONs here: https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to
// And how to deserialize here: https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/deserialization

enum Options {
    WRITE = 1,
    DISPLAY = 2,
    LOAD = 3,
    SAVE = 4,
    QUIT = 5,
}
class Program
{
    static void Main(string[] args)
    {
        List<Entry> entries = new List<Entry>();
        Menu.Welcome();
        uint option = 9;
        do {
         option = Menu.Display();
         switch (option) {
            case (uint) Options.WRITE:
                Entry entry = new Entry();
                entry.AddNewEntry();
                entries.Add(entry);
                break;
            case (uint) Options.DISPLAY:
                foreach (Entry e in entries) {
                    e.Display();
                }
                break;
            case (uint) Options.LOAD:
                entries = Entry.LoadFromFile();
                break;
            case (uint) Options.SAVE:
                Entry.SaveToFile(entries);
                break;
            case (uint) Options.QUIT: // EXIT
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
         }
        } while (option != 5);
    }
}