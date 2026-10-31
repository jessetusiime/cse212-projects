public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // My plan includes the following steps:
        // Create a double array with length positions
        // Loop through each postion in the array starting  at index 0
        // Multiply the given number by the position plus 1
        // Store the calculated multiple in that position
        // Return the array

        double[] results = new double[length];

        for (int i = 0; i < length; i++)
        {
            results[i] = number * (i + 1);
        }

        return results;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // I will use the list-slicing method. My plan includes the following
        // Calculate the index where the last amount items begin.
        // Copy those items into a temporary list using GetRange()
        // Remove those items from the original list using RemoveRange()
        // Insert the saved items at the beginning of the original list.
        // The original list is now rotated to the right

        int startIndex = data.Count - amount;

        List<int> lastItems = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, lastItems);
    }
}
