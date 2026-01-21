using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public record Student(string Name, int Score);

public class StudentProcessor
{
    public string ProcessStudents(string[] items, int minScore)
    {
        // 1. Parse strings into Student objects
        var students = items
            .Select(item => 
            {
                var parts = item.Split(':');
                return new Student(parts[0], int.Parse(parts[1]));
            })
            // 2. Filter by minScore
            .Where(s => s.Score >= minScore)
            // 3. Sort: Score (Desc), then Name (Asc)
            .OrderByDescending(s => s.Score)
            .ThenBy(s => s.Name)
            .ToList();

        // 4. Serialize to JSON
        return JsonSerializer.Serialize(students);
    }
}
