using System;

namespace AdventureOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new Day1();
            d1.exec();
            
            var d2 = new Day2();
            d2.exec();

            var d3 = new Day3();
            d3.exec();

            var d4 = new Day4();
            d4.exec();

            var d5 = new Day5();
            d5.exec();

            var d6_1 = new Day6pt1();
            d6_1.exec();

            var d6_2 = new Day6pt2();
            d6_2.exec();
        }
    }
}
