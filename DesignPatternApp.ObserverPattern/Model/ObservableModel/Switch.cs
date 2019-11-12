using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.ObserverPattern.Model.ObservableModel
{
   public  class Switch : Observable
   {
       private bool _state = false;

       public bool State
       {
           get { return _state; }
           set
           {
               _state = value;
                NotifyAllObservers();
           }
       }
   }
}
