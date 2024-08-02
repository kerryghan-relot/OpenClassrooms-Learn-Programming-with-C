namespace Communication
{
    public class UserInput
    {

        /// <summary>
        /// Check if a url is given inside the args array. Otherwise, ask the user to enter a URL.
        /// It asks a URL until a valid one has been entered.
        /// </summary>
        /// <param name="args">List of arguments that was passed to the main function</param>
        /// <returns>A valid URL in string format</returns>
        public static string GetURL(string[] args)
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

            while (!IsValidURL(urlString))
            {
                Console.WriteLine(urlString + " is not a well-formed URL\n" +
                                  "Please, try again.");
                urlString = AskForUrl();

            }
            
            Console.WriteLine("Well done!\n" + 
                              urlString + " is a well-formed URL");

            return urlString;
        }

        /// <summary>
        /// Prompt user for URL
        /// </summary>
        /// <returns>Prompt user for URL</returns>
        public static string AskForUrl()
        {
            Console.WriteLine("Please enter a valid URL:");

            return Console.ReadLine(); ;
        }

        /// <summary>
        /// Check if a string is a well-formed URL
        /// </summary>
        /// <param name="urlString">A string that should be a valid URL</param>
        /// <returns>true if the URL is well formed, else false</returns>
        private static bool IsValidURL(string urlString)
        {
            return (Uri.IsWellFormedUriString(urlString, UriKind.Absolute));
        }
    }
}