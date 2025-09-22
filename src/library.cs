using System.Linq;

namespace Kt {
    class Library : Building {
        private string[] _books;
        public string[] Books {
            get {
                return _books;
            }
        }

        public Library(string address, string[] books) : base(address){
            _books = books;
        }

        public bool HasBook(string book){
            return _books.Contains(book);
        }
    }
}