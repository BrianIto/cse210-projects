using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        Console.Write("Your grade is ");
        string letter = "F";
        string sign = "";
        //Calculate the letter
        if (grade >= 90) {
           letter = "A" ;
        } else if (grade >= 80) {
            letter = "B";
        } else if (grade >= 70) {
            letter = "C";
        } else if (grade >= 60) { 
            letter = "D";
        }
        //Calculate the sign
        if (grade <= 93 && grade > 60) {
            if (grade % 10 >= 7) {
                sign = "+";
            } else if (grade % 10 <= 3) {
                sign = "-";
            } 
        }
        Console.WriteLine(letter+sign);
    }
}