using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.StatePattern.Player;

namespace DesignPatternApp.StatePattern.TurnOffLamp
{
    public class OnState : IState
    {

        public void PressPlay(LampManager manager)
        {
           
            manager.SetState(new OffState());
            manager.StateName = "Lamp is turning off!";
            Console.WriteLine("lamp is turning 0ff!");

        }
    }
}
