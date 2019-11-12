using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.StatePattern.Player;

namespace DesignPatternApp.StatePattern.TurnOffLamp
{
    public class OffState : IState
    {
        
        public void PressPlay(LampManager manager)
        {
            manager.SetState(new OnState());
            manager.StateName = "Lamp is Turning on!";
            Console.WriteLine("lamp is turning on!");
        }
    }
}
