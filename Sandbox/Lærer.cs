using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class Lærer : Person
    {
        public string Bankkonto { get; set; }

        // Constructor som giver mulighed for at angive navn
        public Lærer(string fornavn, string efternavn, string bankkonto): base(fornavn, efternavn)
        {
            this.Bankkonto = bankkonto; 
            //this.Fornavn = fornavn;
            //this.Efternavn = efternavn;
        }

        public override string ToString()
        {
            return base.ToString() + " bankkonto " + this.Bankkonto;
        }

        public abstract int udbetalSalary();
    }
}
