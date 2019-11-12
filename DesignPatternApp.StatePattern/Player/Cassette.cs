using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.StatePattern.Player
{
    public enum State
    {
        Play = 1,
        Pause = 2

    }
    public class Cassette
    {
        public  int Id { get; set; }
        public  string Name { get; set; }
        public State State { get; set; }

       //public Mp3PlayerManager CurrentState => CassetteFactory.Create(this);
        public Mp3PlayerManager CurrentState
        {
            get { return CassetteFactory.Create(this); }
        }
    }
}
