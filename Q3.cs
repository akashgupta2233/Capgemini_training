public static void SwapWithRef(ref int a, ref int b)
{
    // Example: a = 5, b = 10
    a = a + b; // a becomes 15
    b = a - b; // b becomes 5 (15 - 10)
    a = a - b; // a becomes 10 (15 - 5)
}
