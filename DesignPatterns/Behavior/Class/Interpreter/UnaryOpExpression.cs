using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Class.Interpreter
{
    public class UnaryOpExpression : AbstractExpression
    {
        public AbstractExpression Operand { get; set; }
        public string Operator { get; set; }

        public UnaryOpExpression(AbstractExpression operand, string op)
        {
            Operand = operand;
            Operator = op;
        }
        public override object Interpret(Context context)
        {
           switch (Operator)
            {
                case "-":
                    return -(int)Operand.Interpret(context);
                default:
                    throw new InvalidOperationException($"Unknown operator: {Operator}");
            }
        }
    }
}
