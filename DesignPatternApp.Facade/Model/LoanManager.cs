using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Facade.Model
{
    public  class LoanManager
    {
        public  List<Loan> Loans = new List<Loan>()
        {
            new Loan(1,DateTime.Now.AddDays(-2), 100 ,new User(121,"Fatemeh MOntazeri" , 55555555)) ,
            //new Loan(2,DateTime.Now ,100 ,new User(122,"Zahra Montazeri" , 777988884)),


        };
        public  int BorrowedTimes(int bookId)
        {
           
            if (Loans.Any(i => i.Id == bookId)) return Loans.Count(i => i.Id == bookId);

            return 0;
        }


        public void AddLoan(int id, DateTime expireDate, int bookId, User user)
        {
            // check the book is loanable
            if(Loans.Any(i=>i.Id == id)) Console.WriteLine("The loanId is duplicate! please enter different  loanId ");
            else
                Loans.Add(new Loan(id, expireDate, bookId, user));
           
        }
        public  List<Loan> GetLoans(int bookId)
        {
            return Loans.Where(i => i.BookId == bookId).ToList();

        }
    }
}
