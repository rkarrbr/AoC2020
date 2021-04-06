using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventureOfCode2020
{
    class Passport
    {
        string rawInput;
        string byr; //(Birth Year)
        string iyr; // (Issue Year)
        string eyr; // (Expiration Year)
        string hgt; // (Height)
        string hcl; // (Hair Color)
        string ecl; // (Eye Color)
        string pid; // (Passport ID)
        string cid; // (Country ID) 

        public Passport(string rawInput)
        {
            this.rawInput = rawInput;
            var pairs = this.rawInput.Split(" ");

            var kvPairs = new List<KeyValuePair<string, string>>();
            foreach (var pair in pairs)
            {
                var parts = pair.Split(":");
                kvPairs.Add(new KeyValuePair<string,string>(parts[0], parts[1]));
            }
            byr = kvPairs.Where(p => p.Key == "byr").Select(p => p.Value).FirstOrDefault();
            iyr = kvPairs.Where(p => p.Key == "iyr").Select(p => p.Value).FirstOrDefault();
            eyr = kvPairs.Where(p => p.Key == "eyr").Select(p => p.Value).FirstOrDefault();
            hgt = kvPairs.Where(p => p.Key == "hgt").Select(p => p.Value).FirstOrDefault();
            hcl = kvPairs.Where(p => p.Key == "hcl").Select(p => p.Value).FirstOrDefault();
            ecl = kvPairs.Where(p => p.Key == "ecl").Select(p => p.Value).FirstOrDefault();
            pid = kvPairs.Where(p => p.Key == "pid").Select(p => p.Value).FirstOrDefault();
            cid = kvPairs.Where(p => p.Key == "cid").Select(p => p.Value).FirstOrDefault();
        }

        internal bool valid1()
        {
            if(
                byr != null &&
                iyr != null &&
                eyr != null &&
                hgt != null &&
                hcl != null &&
                ecl != null &&
                pid != null //&&
                //cid != null
            ){
                return true;
            }
            return false;
        }

        internal bool valid2()
        {
            if (!valid1())
                return false;

            var rx_byr = new Regex(@"19[2-9][0-9]|200[0-2]").Matches(byr).Count;
            var rx_iyr = new Regex(@"201[0-9]|2020").Matches(iyr).Count;
            var rx_eyr = new Regex(@"202[0-9]|2030").Matches(eyr).Count;
            var rx_hgt = new Regex(@"1[5-8][0-9]cm|19[0-3]cm|59in|6[0-9]in|7[0-3]in").Matches(hgt).Count;
            var rx_hcl = new Regex(@"#[a-f0-9]{6}").Matches(hcl).Count;
            var rx_ecl = new Regex(@"amb|blu|brn|gry|grn|hzl|oth").Matches(ecl).Count;
            var rx_pid = new Regex(@"[0-9]{9}").Matches(pid).Count;

            if (rx_byr == 0 || rx_iyr == 0 || rx_eyr == 0 || rx_hgt == 0 || rx_hcl == 0 || rx_ecl == 0 || rx_pid == 0)
                return false;

            return true;
        }
    }
}
