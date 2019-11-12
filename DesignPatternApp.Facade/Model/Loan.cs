using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Facade.Model
{
   public  class Loan
    {
        public Loan()
        {
            
        }

        public Loan(int id , DateTime expireDate  ,int bookId , User user)
        {
            this.Id = id;
            this.ExpireDate = expireDate;
            this.BookId = bookId;
            this.User = user;

        }
        public int Id { get; set; }
        public int BookId { get; set; }
        public DateTime ExpireDate { get; set; }
        public User User { get; set; }

    }
}
