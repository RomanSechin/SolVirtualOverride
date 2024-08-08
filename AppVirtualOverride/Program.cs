using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppVirtualOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SafeOwner owner = new SafeOwner();
            Safe safe = new Safe();
            JevelThief jewelThief = new JevelThief(); 
            jewelThief.OpenSafe(safe, owner);
            Console.ReadKey(true);
        }
    }
    
}
