using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Facade.Model
{
   public  class BookManager
    {

        public  List<Book> Books = new List<Book>()
        {
            new Book(100,"Angular js" ,true , 2),
            new Book(200,"Asp.net",false ,5)
        };

        public  void AddBook(int id, string title, bool isLoanable, int quantity)
        {
            Books.Add(new Book(id, title, isLoanable , quantity));
        }

        public  Book GetBook(int bookId)
        {
            if (Books.Any(i => i.Id == bookId))
                return Books.Single(i => i.Id == bookId);

            return null;
        }
    }
}
