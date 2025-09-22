using System;

namespace Kt {
    class Person {
        private string _firstName = "";
        private string _lastName = "";
        private int _age = 0;

        public string FirstName {
            get {
                return _firstName;
            }
            set {
                _firstName = value;
            }
        }

        public string LastName {
            get {
                return _lastName;
            }
            set {
                _lastName = value;
            }
        }

        public int Age {
            get {
                return _age;
            }
            set {
                if(value < 0) throw new ArgumentException();
                _age = value;
            }
        }

        public Person(string first, string last, int age){
            FirstName = first;
            LastName = last;
            Age = age;
        }
    }
}