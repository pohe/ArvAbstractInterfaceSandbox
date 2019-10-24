using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Elev : Person
    {
        public string StudiekortId { get; set; }

        // Constructor som giver mulighed for at angive navn
        public Elev(string fornavn, string efternavn) : base(fornavn, efternavn)
        {
        }

        public Elev(string fornavn, string efternavn, string studiekortId)
            : base(fornavn, efternavn)
        {
            this.StudiekortId = studiekortId;
        }
    }
}
