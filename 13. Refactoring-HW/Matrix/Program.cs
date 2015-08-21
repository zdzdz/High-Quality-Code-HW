// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="TA">
//   TA
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Matrix
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method of the project.
        /// </summary>
        /// <param name="args">
        /// Arguments are not obligatory.
        /// </param>
        private static void Main(string[] args)
        {
            var m = new Matrix(10);
            Console.WriteLine(m);
        }
    }
}
