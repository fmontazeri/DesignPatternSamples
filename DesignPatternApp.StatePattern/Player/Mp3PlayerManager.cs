using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.StatePattern.Player
{
    public abstract class Mp3PlayerManager
    {
        protected Mp3PlayerManager(Cassette caset)
        {
            this.Cassette = caset;
        }
        public Cassette Cassette { get; private set; }
        protected abstract string GetName();
        public  virtual void Play()
        {
            throw  new ArgumentException("an error has been accourred!");
        }
        public  virtual void Pause()
        {
            throw new ArgumentException("an error has been accourred!");
        }

    }

    [CassetteState(State.Play)]
    internal class Play : Mp3PlayerManager
    {
        public Play(Cassette caset) : base(caset)
        {

        }

        protected override string GetName()
        {
            return "در حال اجرا";
        }

        public override void Pause()
        {
            this.Cassette.State = State.Pause;
            Console.WriteLine("th cassette is pausing now!");
        }
    }

    [CassetteState(State.Pause)]
    internal class Pause : Mp3PlayerManager
    {
        public Pause(Cassette caset) : base(caset)
        {

        }

        protected override string GetName()
        {
            return "متوقف";
        }

        public override void Play()
        {
            this.Cassette.State = State.Play;
            Console.WriteLine("th cassette is playing now!");
        }
    }


    internal class CassetteStateAttribute : Attribute
    {
        public State State { get; set; }

        public CassetteStateAttribute(State state)
        {
            this.State = state;
        }
    }


}
