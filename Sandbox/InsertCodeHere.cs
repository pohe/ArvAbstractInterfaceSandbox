using System;
using System.Collections.Generic;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //Arv fra Object klassen

            Person p = new Person("Poul", "Henriksen");
            Console.WriteLine(p.ToString());
            Object o = new Person("Charlotte", "Hansen");

            
            Console.WriteLine(o.ToString());

            int i = 12; 

            IntLærer l = new IntLærer("Jens", "Petersen", "1121212");


            Køretøj o1 = new Køretøj();

            //l =  o1; 

            Console.WriteLine(l.ToString());

            
            List<IId> liste = new List<IId>();

            liste.Add(o1 );
            liste.Add(p);
            liste.Add(l);

            Console.WriteLine("Liste med Id fra objekter");
            foreach (IId o2 in liste)
            {
                Console.WriteLine(o2.Id());
            }

            //Arv mellem klasser

            //Lærer l = new Lærer("Anders", "Andersen");
            //l.CprNummer = "123456-1234";
            //l.Bankkonto = "0000-12345678";

            //Elev e = new Elev("Mikkel", "Mikkelsen");
            //e.CprNummer = "123456-1234";
            //e.StudiekortId = "1234";

            //Console.WriteLine(l.ToString());    // Lærer (navnet på klassen)
            //Console.WriteLine(e.ToString());    // Elev (navnet på klassen)

            //Console.WriteLine(l.FuldtNavn());    // Anders Andersen
            //Console.WriteLine(e.FuldtNavn());    // Mikkel Mikkelsen





            // The LAST line of code should be ABOVE this line
        }
    }
}