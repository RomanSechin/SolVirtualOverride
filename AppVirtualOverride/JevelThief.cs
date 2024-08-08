using System;

namespace AppVirtualOverride
{
    class JevelThief : Locksmith {
        private string _stolenJevels;
        protected override void ReturnContents(string safeContents, SafeOwner owner) { 
            _stolenJevels = safeContents;
            Console.WriteLine($"I'm stealing the jewels! I stole: {_stolenJevels}");
        }
    }
    
}
