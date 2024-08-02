namespace Communication
{
    public class FileGeneration
    {
		/// <summary>
		/// Write the content to the designated file. If it exists, it will be overwritten. If not it will be created.
		/// </summary>
		/// <param name="fileName">File name as a string that should include the extension</param>
		/// <param name="content">The whole content you want to write in your file</param>
        public static void WriteToFile(string fileName, string content)
        {
			try
			{
				File.WriteAllText(fileName, content);

				Console.WriteLine("Content successfully written to " + fileName);
			}
			catch (IOException e)
			{
				Console.WriteLine("Could not write your content to " + fileName + ":\n" + 
								  e.ToString());
			}
        }
    }
}
