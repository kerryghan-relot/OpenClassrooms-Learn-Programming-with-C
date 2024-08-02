

namespace Exceptions
{
    public class TemperatureAverage
    {
        /// <summary>
        /// Displays the average temperature from values provided as command-line arguments
        /// </summary>
        /// <param name="args">The values you want to parse out to compute the average of</param>
        /// <remarks>The temperatures are expressed in degrees celcius</remarks>
        private static void Main(string[] args)
        {
            try
            {
                // Convert the array to a usable format
                List<int> recordedTemperaturesInDegreesCelcius = StringToIntArray(args);

                // Calculate and print the average temperature
                int averageTemperature = SimpleMath.CalculateAverage(recordedTemperaturesInDegreesCelcius);

                // Display the answer
                Console.WriteLine("The average temperature is " + averageTemperature);
            }
            catch (FormatException e)
            {
                Console.WriteLine("All the given numbers must be integers.\n" +
                                  "Exception Message: " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot calculate the average temperature without any value. Be sure to pass values as arguments.\n" +
                                  "Exception Message: " + e.Message);
            }
            
        }
        private static List<int> StringToIntArray(string[] StringArray)
        {
            List<int> IntArray = new List<int>();

            // Fill the list from values provided by the array of strings
            foreach (string str in StringArray)
            {
                IntArray.Add(int.Parse(str));
            }

            return IntArray;
        }
    }
}