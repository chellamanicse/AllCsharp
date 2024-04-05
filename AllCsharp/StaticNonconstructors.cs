using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCsharp
{
    public class StaticNonconstructors
    {
        public StaticNonconstructors() {
            Console.WriteLine("Nonconstructors");
        }
        static StaticNonconstructors()
        {
            Console.WriteLine("StaticNonconstructors");
        }
    }
}
