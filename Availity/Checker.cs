using System;
using System.Collections.Generic;
using System.Text;

namespace Availity
{
    class Checker
    {


        public static bool IsBalanced(string value)
        {
           
            bool IsBalanced = false;
            Stack<char> stack = new Stack<Char>();
            if (value.Length > 0)
            {
                foreach (char c in value)
                {
                    if (c == '(' || c == '{' || c == '[') stack.Push(c);
                    else
                    {
                        char top = stack.Peek();

                        if (top == '(')
                        {
                            if (c != ')') return false;
                            stack.Pop();

                        }
                        if (top == '{')
                        {
                            if (c != '}') return false;
                            stack.Pop();
                        }
                        if (top == '[')
                        {
                            if (c != ']') return false;
                            stack.Pop();
                        }

                    }


                    if (stack.Count == -1) IsBalanced = false;
                }
                if (stack.Count == 0) IsBalanced = true;
            }
            return IsBalanced;
        }



    }
}
