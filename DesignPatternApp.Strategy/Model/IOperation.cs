using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Strategy.Model
{
    public interface IOperation
    {
        int doOperation(int num1, int num2);
    }
}
