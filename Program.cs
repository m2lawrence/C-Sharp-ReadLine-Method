//The ReadLine method. To end this listing, you can use Ctrl+Z.

//The ReadLine method reads a line of text up to a carriage return, a line feed, or both. The ReadLine method then returns all characters
//read except the carriage return and line feed. If the end of the stream is reached, the value null is returned.

using System;
using System.Text;
namespace ReadLine
{
	class ReadLine
	{
		public static void Main(string[] args)
		{
			StringBuilder Input = new StringBuilder();
			string buff;
			
			Console.WriteLine("Enter text. When done, press Ctrl+Z:");  

			while ( (buff = Console.ReadLine()) != null )  //If the line read is equal to null, the input is ended.
			{
				Input.Append(buff);  //If information is read, it is appended to the Input string.
				Input.Append("\n");  //Because line-feed information is removed from the string, here it adds a line
									 //feed back to the string being created, so that the final output displayed matches what the user entered.
			}
			Console.WriteLine("\n\n==========>\n");
			Console.Write( Input );
			Console.Write("\n\n");
			
			//use Ctrl+Z here to end!
			Console.ReadKey(true);  //pause.
		}
	}
}