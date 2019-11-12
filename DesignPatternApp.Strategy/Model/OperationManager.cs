using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Strategy.Model
{
    public class OperationManager
    {
        private IOperation operation;
        public OperationManager(IOperation _operation)
        {
            operation = _operation;
        }
       
        public int executeOperation(int num1, int num2)
        {
            return operation.doOperation(num1, num2);
        }
    }
}
