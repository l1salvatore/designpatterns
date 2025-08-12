using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Class.Interpreter
{
   public class Context
    {
        /// <summary>
        /// The context holds the state of the interpreter.
        /// </summary>
        public string Input { get; set; }
        /// <summary>
        /// Initializes a new instance of the Context class.
        /// </summary>
        /// <param name="input">The input string to be interpreted.</param>
        public Context(string input)
        {
            Input = input;
        }
        /// <summary>
        /// Gets the current input.
        /// </summary>
        /// <returns>The current input string.</returns>
        public string GetInput()
        {
            return Input;
        }
    }
}
