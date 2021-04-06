using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureOfCode2020
{
    class Day4
    {
        List<Passport> passports;
        public Day4()
        {
            passports = new List<Passport>();

            StringBuilder sb = new StringBuilder();
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Git\AoC2020\AdventureOfCode2020\AdventureOfCode2020\Day4\data.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line == "")
                {
                    passports.Add(new Passport(sb.ToString().Trim())); //trim behövs i detta fall då vi lagt till extra mellanslag på slutet av else satsen.
                    sb.Clear();
                }
                else
                {
                    sb.Append(line);
                    sb.Append(" ");
                }            
            }
            if(sb.Length > 0)
            {
                passports.Add(new Passport(sb.ToString().Trim()));
            }
        }

        public void exec()
        {

            int validPassports = 0;
            foreach(var passport in passports)
            {
                if (passport.valid1())
                {
                    validPassports++;
                }
            }
            Console.WriteLine("valid passports (pt1): " + validPassports);

            validPassports = 0;
            foreach(var passport in passports)
            {
                if (passport.valid2())
                {
                    validPassports++;
                }
            }
            Console.WriteLine("valid passports (pt2): " + validPassports);
        }
    }
}
