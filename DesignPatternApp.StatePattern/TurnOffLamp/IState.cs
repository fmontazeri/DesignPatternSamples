using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.StatePattern.TurnOffLamp;

namespace DesignPatternApp.StatePattern.Player
{
    public interface IState
    {
        void PressPlay(LampManager manager);
    }

   
   
}
