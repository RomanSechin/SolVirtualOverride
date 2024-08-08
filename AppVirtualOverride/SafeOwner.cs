using System;

namespace AppVirtualOverride
{
    class SafeOwner {
        private string _valuables = "";
        public void ReceiveContents(string safeContents) { 
            _valuables = safeContents;
            Console.WriteLine($"Thank you for returning my {_valuables}!");
        }
    }
}
