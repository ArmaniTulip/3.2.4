namespace _3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 0, 0, 0, 0 };

            Console.WriteLine("Enter the 1st Number.");
            inputArray[0] = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number.");
            inputArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd Number.");
            inputArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 4th Number.");
            inputArray[3] = Convert.ToInt32(Console.ReadLine());

            double[] returnArray =TotalAverage(inputArray);
            Console.WriteLine($"The total is {returnArray[0]} and the average is {returnArray[1]}");


        }

        static double[] TotalAverage(int[] inputArray)
        {
            double total = (inputArray[0] + inputArray[1] + inputArray[2] + inputArray[3]);
            double average = total / 4;

            double[] outputArray = {total, average};

            return outputArray;
        }
        

        
    }
        
    
}
