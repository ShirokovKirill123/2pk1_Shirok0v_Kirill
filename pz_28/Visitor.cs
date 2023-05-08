using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    class Visitor
    {
        static int count;
        public Visitor()
        {
            count++;
            Console.WriteLine($"Посетитель {count} пришел.");
        }
    }
}
