using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Facade.Model
{
    public class FacadeBookLoan
    {
        private BookManager _bookManager;
        private LoanManager _loanManager;
        private SmsManager _smsManager;

        public FacadeBookLoan( )
        {
            this._loanManager =new LoanManager();
            this._bookManager = new BookManager();
            this._smsManager = new SmsManager();

        }


        public int IsLoanable(int bookId)
        {
           var book = _bookManager.GetBook(bookId);
            if (book == null)
            {
                Console.WriteLine("Not fount book!");
                return -1;
            }

            if (!book.IsLoanable)
            {
                Console.WriteLine("This book isn't Loanable!");
                return -2;
            }

            var countOfLoans = _loanManager.IsLoan(bookId);

            if (countOfLoans > 0) ManagerLoans(bookId);
            return book.Qantity - countOfLoans;

        }

        private void ManagerLoans(int bookId)
        {
            var loans = _loanManager.GetLoans(bookId);
            if(loans != null)
            foreach (var loan in loans)
            {
                if(loan.ExpireDate < DateTime.Now)
                     _smsManager.SendMessage(loan.User.PhoneNumber);
            }
        }
    }
}
