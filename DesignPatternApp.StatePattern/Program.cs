using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.StatePattern.Player;
using DesignPatternApp.StatePattern.TurnOffLamp;

namespace DesignPatternApp.StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region [Reflection]

            //var assemblyType = typeof(Mp3PlayerManager).Assembly.GetTypes();
            //var mp3Type = typeof(Mp3PlayerManager);
            //foreach (var t in assemblyType)
            //{
            //    Console.WriteLine($"(FullName: {t.Name}, IsAssignable Mp3PlayerManager From { t.Name } : { typeof(Mp3PlayerManager).IsAssignableFrom(t) } , Has CassetteState Attribute : {t.GetCustomAttribute(typeof(CassetteStateAttribute))} ");
            //}



            #endregion

            //var cassette = new Cassette() { Id = 1, Name = "Schiller", State = State.Play };
            // cassette.CurrentState.Pause();;


            //var cassette2 = new Cassette() { Id = 1, Name = "Schiller", State = State.Pause };
            //cassette.CurrentState.Play();

            #region Turn Lamp On or OFF

            var currentState = new LampManager();

            var on = new OnState();
            on.PressPlay(currentState);

            var off = new OffState();
            off.PressPlay(currentState);

            Console.WriteLine($"latest state is : {currentState.StateName} ");

            #endregion




            Console.ReadLine();

       
        }
    }
}
