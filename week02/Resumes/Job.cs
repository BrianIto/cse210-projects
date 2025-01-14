using System;

public class Job {
    public string _role;
    public string _company;
    public ushort _startYear;
    public ushort _endYear;

    public void Display() {
        Console.WriteLine($"{_role} ({_company}) {_startYear}-{_endYear}");
    }
}