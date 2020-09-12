using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Dubstep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SongDecoder("WUBWUBABCWUB"));   //"ABC"
            Console.WriteLine(SongDecoder("RWUBWUBWUBLWUB"));  // "R L"
            Console.WriteLine(SongDecoder("WUBWUBIWUBAMWUBWUBX"));  // "I AM X"


        }

        //To make the dubstep remix of this song,
        //Polycarpus inserts a certain number of words "WUB" before the first word of the song(the number may be zero), after the last word(the number may be zero), 
        //and between words(at least one between any pair of neighbouring words), 
        //and then the boy glues together all the words, including "WUB", in one string and plays the song at the club.



        public static string SongDecoder(string input)
        {
           // var res = ;
            
            //List<string> tmp = input.Replace("WUB"," ").Split(" ").ToList();
            

            return string.Join(" ", input.Split("WUB").Where(x => x != ""));
            // return Regex.Replace(input, "(WUB)+", " " ).Trim();
            RNGCryptoServiceProvider rNG = new RNGCryptoServiceProvider();
            

        }
    }
}
