using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>  
        {
            new Running(new DateTime(2025, 02, 15), 30, 5.0),
            new Cycling(new DateTime(2025, 02, 15), 30, 10),
            new Swimming(new DateTime(2025, 02, 15), 45, 15)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}