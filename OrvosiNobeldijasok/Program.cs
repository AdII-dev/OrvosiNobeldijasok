using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings;
using System.Collections.Generic;

namespace OrvosiNobeldijasok
{
    class Program
    {
        static void Main(string[] args)
        {

            var nobeldijasok = new List<Nobeldijas>();
            var sr = new StreamReader(
                path: @"../../../Src/orvosi_nobeldijak.txt",
                encoding: System.Text.Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) nobeldijasok.Add(new Nobeldijas(sr.ReadLine()));
            
            Console.WriteLine($"A díjazottak száma: {nobeldijasok.Count}");
            //for (int i = 0; i < length; i++)
            //{

            //}
            Console.WriteLine($"fasz ");
            Console.ReadKey();
        }
    }
}
