using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AdventureOfCode2020
{
    class Day3
    {
        private char[][] arr;
        private int rowCounter;
        public Day3()
        {
            arr = new char[323][];
            int rowCounter = 0;

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Git\AoC2020\AdventureOfCode2020\AdventureOfCode2020\Day3\data.txt");
            while ((line = file.ReadLine()) != null)
            {
                arr[rowCounter] = line.ToCharArray();
                rowCounter++;
            }
            this.rowCounter = rowCounter;

        }

        public void exec()
        {
            Console.WriteLine("part1: " + exec(rowCounter, 1, 3));
            Console.WriteLine("Part2: " +
                BigInteger.Multiply(
                    BigInteger.Multiply(
                        BigInteger.Multiply(
                            BigInteger.Multiply(exec(rowCounter, 1, 1), exec(rowCounter, 1, 3))
                            , exec(rowCounter, 1, 5))
                        , exec(rowCounter, 1, 7))
                , exec(rowCounter, 2, 1)));

        }

        private int exec(int totalDepth, int down, int right)
        {
            int trees = 0;
            int col = 0;
            for (int row = 0; row < totalDepth; row = row + down)   //step down in row counter.
            {
                if(this.arr[row][col].Equals('#'))   //steps right where we take modulus.
                {
                    trees++;
                }
                col = (col + right) % this.arr[row].Length;
            }
            return trees;
        }
    }
}

