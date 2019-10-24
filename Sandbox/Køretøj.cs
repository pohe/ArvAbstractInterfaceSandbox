using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Køretøj: IId
    {
        public string Regnr { get; set; }
        public int Speed { get; set; }

        public Køretøj()
        {
            Speed = 100;
            Regnr = "AB 121212"; 
        }

        public Køretøj(string regnr, int speed)
        {
            Regnr = regnr;
            Speed = speed;
        }
        public override string ToString()
        {
            return "Speed " + Speed;
        }

        public string Id()
        {
            return Regnr;
        }

    }
}
