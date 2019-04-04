using System;
using MultiBracketValidation.Classes;
using System.Collections;
//using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Please enter a string with brackets to see if it closes properly");
            string input = Console.ReadLine();
            bool answer = BracketValidation(input);
            if (answer)
            {
                Console.WriteLine("Congradulation, the brackets are valid");
            }
            else
            {
                Console.WriteLine("I'm sorry, the brackets are not valid");
            }
            Console.WriteLine("Please press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Checks the characters in a string input to see if each open bracket has a closing bracket
        /// </summary>
        /// <param name="input">Test inputted string</param>
        /// <returns>true if every open bracket is closed; false if it doesn't</returns>
        public static bool BracketValidation (string input)
        {
            Classes.Stack testStack = new Classes.Stack();

            for (int i = 0; i < input.Length; i++)
            {
                
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    testStack.Push(input[i]);
                }
                if (testStack.Top != null && testStack.Top.Value == '(' && input[i] == ')')
                {
                    testStack.Pop();
                }
                if (testStack.Top != null && testStack.Top.Value == '{' && input[i] == '}')
                {
                    testStack.Pop();
                }
                if (testStack.Top != null && testStack.Top.Value == '[' && input[i] == ']')
                {
                    testStack.Pop();
                }
              
            }
            if (testStack.Top == null)
            {
                return true;
            }
            return false;
        }
    }
}
