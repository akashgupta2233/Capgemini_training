using System;
using System.Collections.Generic;
using System.Linq;

public class CreatorStats
{
    public string CreatorName { get; set; }
    public double[] WeeklyLikes { get; set; }
    
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
}

public class Program
{
    public void RegisterCreator(CreatorStats record)
    {
        CreatorStats.EngagementBoard.Add(record);
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> topPosts = new Dictionary<string, int>();

        foreach (var creator in records)
        {
            int count = 0;
            foreach (double likes in creator.WeeklyLikes)
            {
                if (likes >= likeThreshold)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                topPosts.Add(creator.CreatorName, count);
            }
        }

        return topPosts;
    }

    public double CalculateAverageLikes()
    {
        if (CreatorStats.EngagementBoard.Count == 0) return 0.0;

        double totalLikes = 0;
        int totalWeeks = 0;

        foreach (var creator in CreatorStats.EngagementBoard)
        {
            foreach (double likes in creator.WeeklyLikes)
            {
                totalLikes += likes;
                totalWeeks++;
            }
        }

        return totalLikes / totalWeeks;
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice)) continue;

            switch (choice)
            {
                case 1:
                    CreatorStats newCreator = new CreatorStats();
                    Console.WriteLine("Enter Creator Name:");
                    newCreator.CreatorName = Console.ReadLine();

                    Console.WriteLine("Enter weekly likes (Week 1 to 4):");
                    double[] likes = new double[4];
                    for (int i = 0; i < 4; i++)
                    {
                        likes[i] = double.Parse(Console.ReadLine());
                    }
                    newCreator.WeeklyLikes = likes;

                    p.RegisterCreator(newCreator);
                    Console.WriteLine("Creator registered successfully");
                    break;

                case 2:
                    Console.WriteLine("Enter like threshold:");
                    double threshold = double.Parse(Console.ReadLine());
                    var topCreators = p.GetTopPostCounts(CreatorStats.EngagementBoard, threshold);

                    if (topCreators.Count == 0)
                    {
                        Console.WriteLine("No top-performing posts this week");
                    }
                    else
                    {
                        foreach (var entry in topCreators)
                        {
                            Console.WriteLine($"{entry.Key} - {entry.Value}");
                        }
                    }
                    break;

                case 3:
                    double avg = p.CalculateAverageLikes();
                    Console.WriteLine($"Overall average weekly likes: {avg}");
                    break;

                case 4:
                    Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                    exit = true;
                    break;
            }
            Console.WriteLine(); // Spacing for menu readability
        }
    }
}
