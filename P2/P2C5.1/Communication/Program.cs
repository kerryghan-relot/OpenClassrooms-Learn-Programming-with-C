namespace Communication
{
    public class Program
    {
        /// <summary>
        /// Get the programm running.
        /// </summary>
        /// <param name="args">The argument to pass to the program. This should be nothing or a valid URL.</param>
        /// <remarks>I am doing all three exercises of this chapter into this single project for convenience.</remarks>
        private static void Main(string[] args)
        {
            string url = UserInput.GetURL(args);  // Exercise 5.1

            string content = RemoteContent.GetContent(url);

            Console.WriteLine(content);  // Exercise 5.2

            FileGeneration.WriteToFile("output.html", content);
        }
    }
}
