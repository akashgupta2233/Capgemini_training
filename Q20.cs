using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    public Student(string name, int age, int marks)
    {
        Name = name;
        Age = age;
        Marks = marks;
    }
}

public class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        if (x == null || y == null) return 0;

        // 1. Sort by Marks (Descending)
        // Compare y to x to get the higher value first
        int marksComparison = y.Marks.CompareTo(x.Marks);

        if (marksComparison != 0)
        {
            return marksComparison;
        }

        // 2. If marks are equal, sort by Age (Ascending)
        // Compare x to y to get the lower (youngest) value first
        return x.Age.CompareTo(y.Age);
    }
}
