namespace Communication
{
    public class UserInput
    {
        private static void Main(string[] args)
        {
            string urlString = "";

            // assign a value to urlString or exit
            switch (args.Length)
            {
                case 0:
                    urlString = AskForUrl();
                    break;
                case 1:
                    urlString = args[0];
                    break;
                default:
                    Console.WriteLine("Please run the program with the desired URL or no argument at all");
                    Environment.Exit(-1);
                    break;
            }

            Console.WriteLine("\n   ...Checking URL " + urlString + "\n");

            if (IsValidURL(urlString))
            {
                Console.WriteLine(urlString + " is a well-formed URL");
            }
            else
            {
                Console.WriteLine(urlString + " is not a well-formed URL");
            }
        }

        /// <summary>
        /// Prompt user for URL
        /// </summary>
        /// <returns>Prompt user for URL</returns>
        static string AskForUrl()
        {
            Console.WriteLine("Please enter a valid URL:");

            return Console.ReadLine(); ;
        }

        /// <summary>
        /// Check if a string is a well-formed URL
        /// </summary>
        /// <param name="urlString"></param>
        /// <returns>true if the URL is well formed, else false</returns>
        static bool IsValidURL(string urlString)
        {
            return (Uri.IsWellFormedUriString(urlString, UriKind.Absolute));
        }
    }
}