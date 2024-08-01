using System;

namespace Hello
{
	/// <summary>
	/// Declare the class we will be working in for our first (rigorous) Hello World program.
	/// </summary>
	/// <remarks>This was shown it Part 2 Chapter 1 of the OpenClassrooms C# course</remarks>
	public class HelloWorld
	{
        /// <summary>
        /// Simply get the program running; this is where the program starts
        /// </summary>
        /// <param name="args">arguments to pass to the main function</param>
        public static void Main(string[] args)
		{
			SayHelloTo("World");
		}
		/// <summary>
		/// Displays a nice "Hello World!" string in the console !
		/// </summary>
		/// <param name="recipient">Whom you want to say hello to</param>
		private static void SayHelloTo(string recipient)
		{
			Console.WriteLine("Hello " + recipient + "!");
		}
	}
}