using System;

namespace Kt {
    class Reader : Person {
        public void ReadBook(Library lib, string book){
            if(lib.HasBook(book)){
                Console.WriteLine($"Reader {FirstName} {LastName} прочитал книгу {book}");
            }else{
                Console.WriteLine($"Книга {book} не найдена");
            }
        }

        public Reader(string first, string last, int age) : base(first, last, age){}
    }
}