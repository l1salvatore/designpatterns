using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Class.Interpreter
{
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
           context.Input = context.Input.Replace("Terminal", "Interpreted");
        }
    }
}
