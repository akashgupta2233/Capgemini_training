using System;

public class Solution
{
    public double GetCircleArea(double radius)
    {
        // 1. Calculate the area: PI * r^2
        double area = Math.PI * Math.Pow(radius, 2);

        // 2. Round the result to 2 decimal places
        // MidpointRounding.AwayFromZero ensures that .5 rounds to the next digit
        // (e.g., 1.255 becomes 1.26)
        double roundedArea = Math.Round(area, 2, MidpointRounding.AwayFromZero);

        return roundedArea;
    }
}
