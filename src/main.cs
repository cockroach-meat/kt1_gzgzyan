using System;

namespace Kt {
    class Program {
        public static void Main(){
            var library = new Library("ул. Пушкина, д. Колотушкина", new string[]{ "Война и мир", "Тарас Бульба" });

            var reader1 = new Reader("Иван", "Петров", 32);
            reader1.ReadBook(library, "Война и мир");

            var reader2 = new Reader("Антон", "Сидоров", 96);
            reader2.ReadBook(library, "Изучаем C#");
        }
    }
}