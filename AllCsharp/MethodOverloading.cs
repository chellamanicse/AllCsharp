using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCsharp
{
    public class MethodOverloading
    {

        //static void Main(string[] args)
        //{
            
        
        //}

        public void Method()
        {
            Console.WriteLine("1st Method");
           // Console.ReadLine();
        }
        public void Method(int i)
        {
            Console.WriteLine("2nd Method", i);
        }

    }
}
