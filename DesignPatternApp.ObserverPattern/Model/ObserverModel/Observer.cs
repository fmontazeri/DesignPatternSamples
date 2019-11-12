using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.ObserverPattern.Model.ObservableModel;

namespace DesignPatternApp.ObserverPattern.Model.ObserverModel
{
    public abstract class Observer
    {
        protected Observable Observable;
        public abstract void Update();

    }
}
