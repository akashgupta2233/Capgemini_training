using System;

public class UnitConverter
{
    public static double ConvertFeetToCm(int feet)
    {
        // 1. Perform the conversion
        // We use double to maintain precision during calculation
        double cm = feet * 30.48;

        // 2. Round to 2 decimal places
        // MidpointRounding.AwayFromZero ensures that .005 rounds to .01
        return Math.Round(cm, 2, MidpointRounding.AwayFromZero);
    }
}
