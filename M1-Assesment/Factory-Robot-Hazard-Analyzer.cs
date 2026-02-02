using System;

// User-defined exception class
public class RobotSafetyException : Exception
{
    public RobotSafetyException(string message) : base(message)
    {
    }
}

public class RobotHazardAuditor
{
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        // 1. Validate Arm Precision
        if (armPrecision < 0.0 || armPrecision > 1.0)
        {
            throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
        }

        // 2. Validate Worker Density
        if (workerDensity < 1 || workerDensity > 20)
        {
            throw new RobotSafetyException("Error: Worker density must be 1-20");
        }

        // 3. Validate Machinery State and determine Factor
        double machineRiskFactor = 0.0;
        if (machineryState == "Worn")
        {
            machineRiskFactor = 1.3;
        }
        else if (machineryState == "Faulty")
        {
            machineRiskFactor = 2.0;
        }
        else if (machineryState == "Critical")
        {
            machineRiskFactor = 3.0;
        }
        else
        {
            throw new RobotSafetyException("Error: Unsupported machinery state");
        }

        // 4. Calculate Hazard Risk
        // Formula: ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor)
        double hazardRisk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
        
        return hazardRisk;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
            double precision = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Worker Density (1 - 20):");
            int density = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
            string state = Console.ReadLine();

            RobotHazardAuditor auditor = new RobotHazardAuditor();
            double riskScore = auditor.CalculateHazardRisk(precision, density, state);

            Console.WriteLine("Robot Hazard Risk Score: " + riskScore);
        }
        catch (RobotSafetyException ex)
        {
            // Display the specific error message from the custom exception
            Console.WriteLine(ex.Message);
        }
        catch (Exception)
        {
            // General catch for formatting errors (e.g., entering text instead of numbers)
            Console.WriteLine("Invalid input format.");
        }
    }
}
