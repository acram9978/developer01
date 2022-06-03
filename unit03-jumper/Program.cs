using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> parachuteMan = new List<string>();
            parachuteMan.Add(@" ___");
            parachuteMan.Add(@"/___\");
            parachuteMan.Add(@"\   /");
            parachuteMan.Add(@" \ / ");
            parachuteMan.Add(@"  0  ");
            parachuteMan.Add(@" /|\ ");
            parachuteMan.Add(@" / \ ");

            foreach(string person in parachuteMan) {
                Console.WriteLine(person);
            }

            
        }
    }
}
