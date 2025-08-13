using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Class.Interpreter
{
    public class Client
    {
        Context context;

        public Client() { }

        public AbstractExpression Parse(string expression)
        {
            if (expression == "")
            {
                return context.actual;
            }
            if (context != null)
            {
                var a = expression.TakeWhile(Char.IsDigit);
                if (a.Count() != 0)
                {
                    context.actual = new NumberExpression(int.Parse(new string(a.ToArray())));
                    return Parse(expression.Substring(a.Count()));
                }
                else
                {
                   a = expression.TakeWhile(c => c == '+' || c == '-');
                   if (a.Count() != 0)
                   {
                        if (expression.StartsWith("+"))
                        {
                            return new BinaryOpExpression(context.actual, Parse(expression.Substring(a.Count())), "+");
                        }
                        else if (expression.StartsWith("-"))
                        {
                            return new BinaryOpExpression(context.actual, Parse(expression.Substring(a.Count())), "-");
                        }
                        else
                        {
                            throw new InvalidOperationException($"Invalid operator in expression: {expression}");
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException($"Invalid operator in expression: {expression}");


                    }
                }
            }
            else
            {
                context = new Context(expression);

                var a = expression.TakeWhile(Char.IsDigit);
                if (a.Count() != 0)
                {
                    context.actual = new NumberExpression(int.Parse(new string(a.ToArray())));
                    return Parse(expression.Substring(a.Count()));
                }
                else
                {
                    throw new InvalidOperationException($"Invalid expression: {expression}");
                }
            }
        }
        public void Run()
        {
            // Create a context for the interpreter
            // Create expressions
            AbstractExpression exp = Parse("5 + 9".Replace(" ", ""));
            // Interpret the expressions
            Console.WriteLine($"5 + 3 = {exp.Interpret(context)}");
        }


    }
}
