using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>
        {
            "Task 1: Update project documentation.",
            "Task 2: Review pull requests.",
            "Task 3: Fix bugs reported by QA."
        };

        Console.WriteLine("Tasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}
