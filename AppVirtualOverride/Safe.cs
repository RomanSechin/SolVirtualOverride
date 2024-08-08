namespace AppVirtualOverride
{
    class Safe {
        private string _contents = "precious jewels";
        private string _safeCombination = "12345";

        public string Open(string combination) {
            if (combination == _safeCombination) { 
                return _contents;
            }
            return "";
        }

        public void PickLock(Locksmith lockpicker) { 
            lockpicker.Combination = _safeCombination; 
        }    
    }

}
