using System;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// Programming Assignment 1
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 1
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Print the symbols for the first 10 elements of the periodic table
                Console.WriteLine("H");   // Hydrogen
                Console.WriteLine("He");  // Helium
                Console.WriteLine("Li");  // Lithium
                Console.WriteLine("Be");  // Beryllium
                Console.WriteLine("B");   // Boron
                Console.WriteLine("C");   // Carbon
                Console.WriteLine("N");   // Nitrogen
                Console.WriteLine("O");   // Oxygen
                Console.WriteLine("F");   // Fluorine
                Console.WriteLine("Ne");  // Neon
            
                // Keep the console open until 'q' is entered
                input = Console.ReadLine();
            }
        }
    }
}
