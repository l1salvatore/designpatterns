using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Class.Interpreter
{
    public class NumberExpression : AbstractExpression
    {
        public int Number { get; private set; }

        public NumberExpression(int number)
        {
            Number = number;
        }
        public override object Interpret(Context context)
        {
           return Number;
        }
    }
}
