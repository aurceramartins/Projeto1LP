using System;

namespace Projeto1LP
{
    /// <summary>
    /// Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            ///initializes the game
            Controller play = new Controller();
            play.Play();
        }
    }
}
