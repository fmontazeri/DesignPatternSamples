using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.FactoryPattern
{
    public  abstract class VehicleFactory
    {
        public  abstract  IVehicle GetVehicle<T>() where  T : class ;
    }
}
