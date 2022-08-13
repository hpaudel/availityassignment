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
            
            foreach (char c in value)
            {
                if (c=='(' || c=='{' || c=='[')
                    stack.Push(c);
                else
                {
                    //stack.Pop();
                    char p = stack.Peek();

                    if (c==p) stack.Pop();
                }

                if (stack.Count == -1) IsBalanced = false;
            }

            if (stack.Count == 0) IsBalanced = true;


            return IsBalanced;
        }



    }
}
