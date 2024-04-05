using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCsharp
{
    public class ParameterizedConstructor
    {
        int x = 0;
        public ParameterizedConstructor(int i)
        {
            Console.WriteLine(i.ToString());
            
        }

        public void Display()
        {
            Console.WriteLine(x.ToString());        
        }

    }
}
