﻿using System;


namespace RandomRomanNameGen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Name part strings
            Random rnd = new Random();
            String[] pre = { "App", "Au", "Cae", "Dec", "Fau", "Flav", "Gai", "Gal", "Gnae", "Kae", "Luc", "Mam", "Man", "Mar", "Met", "Num", "Oct", "Pub", "Quin", "Sec", "Secun", "Sept", "Serv", "Sex", "Spur", "Tert", "Ti", "Tiber" };
            String[] root = { "a", "e", "i", "o", "u", "er", "av", "mi", "ban", "bat", "lec", "tis", "pu", "uil", "me", "si", "to", "un", "ro", "fid", "re", "so", "id", "il", "on" };
            String[] suff = { "aeus", "aius", "anos", "anus", "arna", "as", "anas", "cius", "eius", "ena", "enna", "enas", "erna", "eus", "ius", "ienus", "ina", "icus", "ianus", "ina", "inna", "inas", "is", "iis", "phius", "uctus", "unus", "us", "utor" };

            // Generate random indexes for part strings
            int pIndex = rnd.Next(pre.Length);
            int jIndex = rnd.Next(root.Length);
            int sIndex = rnd.Next(suff.Length);

            // Display the result
            Console.WriteLine("Random Roman Name of the Day: ");
            Console.WriteLine("{0}{1}{2}", pre[pIndex], root[jIndex], suff[sIndex]);
            Console.ReadLine();

            
        }
    }
}
