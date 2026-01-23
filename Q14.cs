using System;
using System.IO;

public class LogFilter
{
    public static void ExtractErrorLogs(string inputPath, string outputPath)
    {
        try
        {
            // Use 'using' statements to ensure file handles are closed automatically
            using (StreamReader reader = new StreamReader(inputPath))
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Case-insensitive check for "ERROR"
                    if (line.Contains("ERROR", StringComparison.OrdinalIgnoreCase))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("Error logs extracted successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: Source log file not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: An I/O error occurred: {ex.Message}");
        }
    }
}
