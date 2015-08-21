// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Point.cs" company="TA">
//   TA
// </copyright>
// <summary>
//   The point.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Matrix
{
    /// <summary>
    ///     The point.
    /// </summary>
    internal class Point
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">
        /// The x variable.
        /// </param>
        /// <param name="y">
        /// The y variable.
        /// </param>
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        ///     Gets or sets the x variable.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        ///     Gets or sets the y variable.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        ///     The + operator overridden.
        /// </summary>
        /// <param name="p1">
        ///     The p 1 variable.
        /// </param>
        /// <param name="p2">
        ///     The p 2 variable.
        /// </param>
        /// <returns>
        ///     The method returns a new point which is a sum of the coordinates of the initial points.
        /// </returns>
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
    }
}
