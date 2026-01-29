using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Example Input
        List<int> ids = new List<int> { 1, 4, 5 };
        Dictionary<int, int> salaryDict = new Dictionary<int, int>()
        {
            { 1, 20000 },
            { 4, 40000 },
            { 5, 15000 }
        };

        long total = GetTotalSalary(ids, salaryDict);
        Console.WriteLine(total); // Output: 75000
    }

    public static long GetTotalSalary(List<int> ids, Dictionary<int, int> salaryDict)
    {
        long totalSalary = 0;

        foreach (int id in ids)
        {
            // TryGetvalue is safer and more efficient than checking ContainsKey then indexing
            if (salaryDict.TryGetValue(id, out int salary))
            {
                totalSalary += salary;
            }
        }

        return totalSalary;
    }
}
