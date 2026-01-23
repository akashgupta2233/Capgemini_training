using System;

public class ArrayUtils
{
    public static T[] MergeSortedArrays<T>(T[] a, T[] b) where T : IComparable<T>
    {
        int n = a.Length;
        int m = b.Length;
        T[] merged = new T[n + m];

        int i = 0; // Pointer for array a
        int j = 0; // Pointer for array b
        int k = 0; // Pointer for result array

        // Loop until one array is exhausted
        while (i < n && j < m)
        {
            // Compare elements using IComparable.CompareTo
            // Returns < 0 if a[i] is smaller than b[j]
            if (a[i].CompareTo(b[j]) <= 0)
            {
                merged[k++] = a[i++];
            }
            else
            {
                merged[k++] = b[j++];
            }
        }

        // Copy remaining elements of a, if any
        while (i < n)
        {
            merged[k++] = a[i++];
        }

        // Copy remaining elements of b, if any
        while (j < m)
        {
            merged[k++] = b[j++];
        }

        return merged;
    }
}
