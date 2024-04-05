using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCsharp
{
    public class Constructor
    {
        int id;
        string Name;
        string address;
        public Constructor() { 
        
            id= 0;
            Name = "Mani";
            address = "Main Address";

        }
        public void Dispaly() {

            Console.WriteLine(id.ToString(),Name,address);
            Console.WriteLine( Name + address);
            Console.ReadLine();
        
        }




    }
}
