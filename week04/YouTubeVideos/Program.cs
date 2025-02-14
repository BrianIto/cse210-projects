using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video v1 = new Video("C# Tutorial", "Bob", 60);
        v1.AddComment("Alice", "Great video!");
        v1.AddComment("Charlie", "I love it!");
        v1.AddComment("Bob", "Thanks for watching!");

        videos.Add(v1);

        Video v2 = new Video("Python Tutorial", "Alice", 45);
        v2.AddComment("Bob", "Great video!");
        v2.AddComment("Charlie", "I love it!");
        v2.AddComment("Alice", "Thanks for watching!");
        videos.Add(v2);

        Video v3 = new Video("Java Tutorial", "Charlie", 30);
        v3.AddComment("Alice", "Great video!");
        v3.AddComment("Bob", "I love it!");
        v3.AddComment("Charlie", "Thanks for watching!");
        v3.AddComment("Alice", "Awesome tutorial!");

        videos.Add(v3);

        foreach (Video v in videos) {
            Console.WriteLine("Title: " + v._title);
            Console.WriteLine("Author: " + v._author);
            Console.WriteLine("Time in Seconds: "+ v._secondsLength);
            Console.WriteLine("Number of Commments: "+v.GetNumberOfComments());
        }
    }
}