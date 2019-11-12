using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Facade.Model
{
   public  class Book
    {
        public Book()
        {
            
        }

        public Book(int id , string title , bool isLoanable , int quantity)
        {
            this.Id = id;
            this.Title = title;
            this.IsLoanable = isLoanable;
            this.Qantity = quantity;
        }
        

        public int Id { get; set; }
        public string Title { get; set; }
        public  bool IsLoanable { get; set; }
        public int Qantity { get; set; }

    }
}
