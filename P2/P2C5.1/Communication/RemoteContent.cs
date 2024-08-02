using System;
using System.Net;

namespace Communication
{
    public class RemoteContent
    {
        /// <summary>
        /// Given a valid URL address, it retrieves the content of that web page from the internet.
        /// </summary>
        /// <param name="url">A valid URL address formated as a string</param>
        /// <returns>The content of the web page</returns>
        public static string GetContent(string url)
        {
            string content = string.Empty;

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    content = webClient.DownloadString(url);
                }
            }
            catch (WebException e)
            {
                Console.WriteLine("Cannot establish connection...\n" +
                                  e.ToString());
            }
            return content; 
        }
    }
}
