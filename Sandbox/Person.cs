using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Person: IId
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string CprNummer { get; set; }

        // Blank constructor
        public Person()
        { }

        // Constructor som giver mulighed for at angive navn
        public Person(string fornavn, string efternavn)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            CprNummer = "1212121";
        }


        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }


        public override string ToString()
        {
            return "Fornavn " + Fornavn + " efternavn " + Efternavn;
        }

        public string Id()
        {
            return CprNummer;
        }
    }
}
