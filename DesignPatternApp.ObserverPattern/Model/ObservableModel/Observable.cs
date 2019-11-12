using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.ObserverPattern.Model.ObserverModel;

namespace DesignPatternApp.ObserverPattern.Model.ObservableModel
{
    public class Observable
    {
        private  readonly  List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            this._observers.Add(observer);
        }

        public void Dettach(Observer observer)
        {
            this._observers.Remove(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
