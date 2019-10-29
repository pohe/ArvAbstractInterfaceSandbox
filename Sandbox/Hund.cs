using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Hund: IComparable<Hund>
    {

        public string Navn { get; private set; }
        public int Vægt { get; private set; }

        public Hund(string navn, int vægt)
        {
            this.Vægt = vægt;
            this.Navn = navn;
        }

        public override string ToString()
        {
            return "Jeg hedder " + Navn + " og vejer " + Vægt + " kg";
        }

        public int CompareTo(Hund obj)
        {
            return this.Navn.CompareTo(obj.Navn);
        }
    }
}
