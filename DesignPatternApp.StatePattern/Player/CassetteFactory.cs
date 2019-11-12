using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.StatePattern.Player
{
    public class CassetteFactory
    {
        public static Mp3PlayerManager Create(Cassette cassette)
        {
            var concretType = typeof(Mp3PlayerManager).Assembly.GetTypes()
                .Single(
                    type =>
                        typeof(Mp3PlayerManager).IsAssignableFrom(type) &&
                        type.GetCustomAttribute(typeof(CassetteStateAttribute)) != null &&
                        ((CassetteStateAttribute)type.GetCustomAttribute(typeof(CassetteStateAttribute))).State == cassette.State);

                    var result = (Mp3PlayerManager)Activator.CreateInstance(concretType, cassette);

            return result;
        }
    }


}
