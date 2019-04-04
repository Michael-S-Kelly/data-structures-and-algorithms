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
            char[] bracketTest = input.ToCharArray();
            Classes.Stack testStack = new Classes.Stack();
            testStack.Push('0');
            if (bracketTest[0] == ')' ||bracketTest[0] == '}' ||bracketTest[0] == ']')
            {
                return false;
            }
            int j = 0;
            for (int i = 0; i < bracketTest.Length; i++)
            {
                if (bracketTest[i] == '(' ||bracketTest[i] == '{' || bracketTest[i] == '[')
                {
                    testStack.Push(bracketTest[i]);
                    if (i + 1 > bracketTest.Length)
                    {
                        return false;
                    }
                    j = i + 1;
                }
            }

            var look = testStack.Peek();

            for (int i = j; i < bracketTest.Length; i++)
            {
                if (bracketTest[i] == '(' || bracketTest[i] == ')' || bracketTest[i] == '{' || bracketTest[i] == '}' || bracketTest[i] == '[' || bracketTest[i] == ']')
                {
                    look = testStack.Peek();
                    if (look.Equals('(') && bracketTest[i] == ')' || look.Equals('{') && bracketTest[i] == '}' || look.Equals('[') && bracketTest[i] == ']')
                    {
                        testStack.Pop();
                    }
                    else
                    {
                        testStack.Push(bracketTest[i]);
                    }
                }
            }
            if (testStack.Peek().Equals('0'))
            {
                return true;
            }
            return false;
        }
    }

    

    
}
