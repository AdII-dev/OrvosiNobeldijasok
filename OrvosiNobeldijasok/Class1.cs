using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobeldijasok
{
    class Nobeldijas
    {
        public int Ev { get; set; }
        public string Nev { get; set; }
        public string SzuletesHalalozas { get; set; }
        public string Orszagkod { get; set; }
    
        public Nobeldijas(string sor)
        {
            var m = sor.Split(';');
            Ev = int.Parse(m[0]);
            Nev = m[1];
            SzuletesHalalozas = m[2];
            Orszagkod = m[3];


        }
    
    }
}
