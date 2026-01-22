using System;

public class HeightCategory
{
    public string GetHeightCategory(int heightCm)
    {
        if (heightCm < 150)
        {
            return "Short";
        }
        else if (heightCm < 180)
        {
            // Because of the first check, we already know heightCm >= 150
            return "Average";
        }
        else
        {
            // This covers heightCm >= 180
            return "Tall";
        }
    }
}
