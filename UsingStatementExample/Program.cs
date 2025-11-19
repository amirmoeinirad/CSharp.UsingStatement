
// Amir Moeini Rad
// June 26, 2025

namespace UsingStatementExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("The 'using' Statement in C#.NET...");
            Console.WriteLine("----------------------------------\n");


            // The 'using' statement ensures the file or resource is closed/disposed automatically.
            // It calls the Dispose() method of the object.
            // The Dispose() method is the implementation of IDisposable.
            // The file is closed automatically after the 'using' block ends.
            // The 'StreamWriter' class implements IDisposable interface.
            // This class is used to write text to a file.
            // If the file does not exist, it creates a new file. If it exists, it overwrites the file.
            using (StreamWriter writer = new StreamWriter("example.txt"))
            {
                writer.WriteLine("Hello, World!");
                writer.WriteLine("This is written using the 'using' statement.");
            }


            Console.WriteLine("Text was written to the file successfully.");
            Console.WriteLine("The file was also closed automatically.");

            Console.WriteLine("\nDone.");
        }
    }
}
