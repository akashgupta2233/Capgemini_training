public static int[] GetMultiplicationRow(int n, int upto)
{
    // Handle the constraint where upto could be 0
    if (upto <= 0) return new int[0];

    int[] row = new int[upto];
    for (int i = 1; i <= upto; i++)
    {
        row[i - 1] = n * i;
    }
    return row;
}
