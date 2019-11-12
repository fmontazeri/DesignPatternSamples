using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.FactoryPattern
{
    public interface IVehicle
    {
        string  Name { get; set; }
        void Drive();
    }
}
