using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class IntLærer : Lærer
    {
        public override int udbetalSalary()
        {
            return 20000;
        }

        public IntLærer(string fornavn, string efternavn, string bankkonto) : base(fornavn, efternavn, bankkonto)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
