using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    /// <summary>
    /// This is some class
    /// </summary>
    public class SomeClass
    {
        /// <summary>
        /// Some function with params <paramref name="parameter1"/> and <paramref name="parameter2"/>. Test change
        /// </summary>
        /// <returns>
        /// void.
        /// </returns>
        /// <example>
        /// <code>
        /// SomeFunction("some string", 123.45);
        /// </code>
        /// </example>
        /// <exception cref="System.OverflowException">Thrown when one parameter is max
        /// and the other is greater than 0.</exception>
        /// See <see cref="SomeOtherFunction(int, float)"/> to do something else.
        /// <param name="parameter1">A string.</param>
        /// <param name="parameter2">A double.</param>
        public static void SomeFunction(string parameter1, double parameter2)
        {

        }

        /// <summary>
        /// Some function with params <paramref name="parameter1"/> and <paramref name="parameter2"/>.
        /// </summary>
        /// <returns>
        /// void.
        /// </returns>
        /// <example>
        /// <code>
        /// SomeFunction(3, 123.45);
        /// </code>
        /// </example>
        /// <exception cref="System.OverflowException">Thrown when one parameter is max
        /// and the other is greater than 0.</exception>
        /// See <see cref="SomeFunction(string, double)"/> to do something else.
        /// <param name="parameter1">An int.</param>
        /// <param name="parameter2">A float.</param>
        public static void SomeOtherFunction(int parameter1, float parameter2)
        {

        }
    }
}
