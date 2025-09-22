namespace Kt {
    class Building {
        private string _address;

        public string Address {
            get {
                return _address;
            }
        }

        public Building(string address){
            _address = address;
        }
    }
}