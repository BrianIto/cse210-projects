using System.Text.Json;

public class Entry {
    public string _question {get; set;} = string.Empty;
    public string _date {get; set;} = string.Empty;
    public string _answer {get; set;} = string.Empty;

    public static string GenerateQuestion() {
        List<string> questions = new List<string> {
            "What did you learn today?",
            "What was the most challenging part of your day?",
            "What are you looking forward to tomorrow?",
            "What are you grateful for today?",
            "What would you like to improve on tomorrow?"
        };
        Random random = new Random();
        int index = random.Next(questions.Count);
        return questions[index];
    }

    public void AddNewEntry() {
        _question = GenerateQuestion();
        Console.WriteLine(_question);
        Console.Write("> ");
        _answer = Console.ReadLine();
        _date = DateTime.Now.ToShortDateString();
    }

    public void Display() {
        Console.WriteLine($"Date: {_date} - Prompt: {_question}");
        Console.WriteLine(_answer);
        Console.WriteLine();
    }

    private static void SaveEntriesToFile(List<Entry> entries, string filename) {
                string jsonString = JsonSerializer.Serialize(entries);
                File.WriteAllText(filename, jsonString);
    }

    private static void LoadEntriesFromFile(List<Entry> entries, string filename) {
        if (File.Exists(filename)) {
            string jsonString = File.ReadAllText(filename);
            List<Entry> jsonEntries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
            entries.AddRange(jsonEntries);
        }
    }

    public static void SaveToFile(List<Entry> entries) {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        SaveEntriesToFile(entries, filename);
    }

    public static List<Entry> LoadFromFile() {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        List<Entry> entries = new List<Entry>();
        LoadEntriesFromFile(entries, filename);
        return entries;
    }

}