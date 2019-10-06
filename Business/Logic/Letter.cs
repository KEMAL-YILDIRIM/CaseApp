using System;
using System.Collections.Generic;

using Business.Exceptions;

namespace Business.Logic
{
    /// <summary>
    /// The letter class.
    /// </summary>
    public class Letter : Count<Char>
    {
        /// <summary>
        /// Calculate the number of repetations of a char within a char array.
        /// </summary>
        /// <typeparam name="TypeItem"></typeparam>
        /// <param name="items">Char[]</param>
        /// <param name="item">Char</param>
        /// <returns></returns>
        public override int FindNumberOfRepetations(in IEnumerable<Char> items, in Char item)
        {
            var letter = item;
            var givenText = new string(items as Char[]);

            if (string.IsNullOrWhiteSpace(givenText))
                throw new CountException("Given text is not valid to find the containing letter.");

            if (!char.IsLetterOrDigit(letter))
                throw new CountException("Given letter is not valid to search inside a text.");

            int repetation = 0;

            int length = givenText.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                if (letter == givenText[i])
                    repetation++;
            }

            return repetation;
        }
    }
}
