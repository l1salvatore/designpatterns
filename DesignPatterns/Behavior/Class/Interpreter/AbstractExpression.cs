using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Class.Interpreter
{
    /// <summary>
    /// The abstract expression class defines the interpret operation that is common to all nodes in the abstract syntax tree.
    /// </summary>
    public abstract class AbstractExpression
    {
        /// <summary>
        /// Interpret method that must be implemented by concrete expressions.
        /// </summary>
        /// <param name="context">The context in which the expression is evaluated.</param>
        public abstract void Interpret(Context context);
    }

}
