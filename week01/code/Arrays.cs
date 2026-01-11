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
        // TODO Problem 1 Start

        // Step1: Create an array of type double with a size equal to length.
        //This array will store the mutiples we generate.
        double[] multiples = new double [length];

        //step2: Use a for loop to generate each multiple
        //The loop should run "length" times , once for each multiple

        for (int i= 0; i < length; i++)
        {
            //step3: Calculate the multiples
            //The first multiples should be number*1
            //the second should be number*2 and so on...

            multiples[i] = number * (i + 1);
        }

        //Step4 return the completed Array
        return multiples;


        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        
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
        // TODO Problem 2 Start
         // Step 1: Understand the goal
    // Rotating to the right means taking elements from the end of the list
    // and moving them to the front, while keeping their order.

    // Step 2: Determine how many elements need to be moved
    // The value 'amount' tells us how many elements from the right end
    // should be rotated to the front of the list.

    // Step 3: Get the elements to move
    // Take the last 'amount' elements from the list and store them temporarily.

    List<int> rightPart= data.GetRange(data.Count- amount, amount);

    // Step 4: Remove those elements from the original list
    // This leaves only the remaining elements in the list.
    data.RemoveRange(data.Count- amount, amount);

    // Step 5: Insert the saved elements at the beginning of the list
    // This completes the right rotation.

    data.InsertRange(0,rightPart);
    }
}
