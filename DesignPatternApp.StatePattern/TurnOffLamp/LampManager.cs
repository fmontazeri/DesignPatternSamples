using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.StatePattern.Player;

namespace DesignPatternApp.StatePattern.TurnOffLamp
{
    public class LampManager
    {
        public LampManager()
        {
            this.CusrrentState =  new OffState();
        }

        public LampManager(IState state)
        {
            this.CusrrentState = state;
        }

        public string StateName { get;  set; }
        private IState CusrrentState { get; set; }

        public void SetState(IState state)
        {
            this.CusrrentState = state;
        }
    }
}
