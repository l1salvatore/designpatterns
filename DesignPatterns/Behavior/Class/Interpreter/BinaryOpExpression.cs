using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Class.Interpreter
{
    public class BinaryOpExpression : AbstractExpression
    {
        public AbstractExpression Left { get; set; }
        public AbstractExpression Right { get; set; }
        public string Operator { get; set; }

        public BinaryOpExpression(AbstractExpression left, AbstractExpression right, string op)
        {
            Left = left;
            Right = right;
            Operator = op;
        }
        public override object Interpret(Context context)
        {
           switch (Operator)
            {
                case "+":
                    return (int)Left.Interpret(context) + (int)Right.Interpret(context);
                case "-":
                    return (int)Left.Interpret(context) - (int)Right.Interpret(context);
                case "*":
                    return (int)Left.Interpret(context) * (int)Right.Interpret(context);
                case "/":
                    return (int)Left.Interpret(context) / (int)Right.Interpret(context);
                default:
                    throw new InvalidOperationException($"Unknown operator: {Operator}");
            }
        }
    }
}
