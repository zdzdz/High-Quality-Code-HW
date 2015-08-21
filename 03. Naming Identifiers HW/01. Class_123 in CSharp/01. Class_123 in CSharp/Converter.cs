// Refactor the following examples to produce code with well-named C# identifiers.

namespace ToStringConverter
{
    using System;

    internal class Converter
    {
        internal string BoolToString(bool value)
        {
            string valueAsString = value.ToString();
            return valueAsString;
        }
    }
}