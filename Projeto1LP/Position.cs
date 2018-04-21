using System;
namespace Projeto1LP
{
    /// <summary>
    /// Position.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Gets the row.
        /// </summary>
        /// <value>get the row.</value>
        public int Row { get; }
        /// <summary>
        /// Gets the column.
        /// </summary>
        /// <value>get the column.</value>
        public int Column { get; }
        /// <summary>
        /// Initializes a new instance of the Position class.
        /// </summary>
        /// <param name="row">Row.</param>
        /// <param name="column">Column.</param>
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
        /// <summary>
        /// Initializes a new instance of the Position class.
        /// </summary>
        /// <param name="column">Column.</param>
        public Position(int column)
        {
            Column = column;
        }
    }
}
