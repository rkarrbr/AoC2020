using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureOfCode2020
{
    class PasswordPolicy
    {
        int minimumCharacter;
        int maximumCharacter;
        char letter;
        string password;

        /// <summary>
        /// Takes raw data in format "p-q x: xxx" and creates a passwordPolicyClass
        /// </summary>
        /// <param name="rawData"></param>
        public PasswordPolicy(string rawData)
        {
            string[] data = rawData.Split(' ');
            letter = data[1].ToCharArray()[0];
            password = data[2];
            string[] bounds = data[0].Split('-');
            minimumCharacter = int.Parse(bounds[0]);
            maximumCharacter = int.Parse(bounds[1]);
        }

        /// <summary>
        /// returns true only if index of "minimumCharacter" XOR "maximumCharacter" contains "letter"
        /// </summary>
        /// <returns></returns>
        internal bool part2validate()
        {
            char[] arr = password.ToCharArray();
            if ( (arr[minimumCharacter - 1].Equals(letter) && !arr[maximumCharacter - 1].Equals(letter))
                || (!arr[minimumCharacter - 1].Equals(letter) && arr[maximumCharacter - 1].Equals(letter)))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// count number of occurence that letter only occurse between minimum and maximum amount of time
        /// </summary>
        /// <returns></returns>
        internal bool part1validate()
        {
            int count = password.Count(f => f == letter);
            if (count >= minimumCharacter && count <= maximumCharacter)
            {
                return true;
            }
            return false;
        }

    }
}
