using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

class RPN
{
    private Stack RPN_Stack;
    private string result;

    public string Result
    {
        get { return this.result; }
        set { this.result = value; }
    }
    public RPN()
    {
        this.RPN_Stack = new Stack();
        this.result = "";
    }

    public RPN(string infixInput)
    {
        CheckSyntax(infixInput);
    }

    private void Output(ref string x)
    {
        if (this.result == "")
            this.result += x;
        else
            this.result += " " + x;
    }
    private int Priority(string T)
    {
        switch (T)
        {
            case "x":
            case "/":
                return 2;           
            case "+":
            case "-":
                return 1;
            default:
                return 0;
        }
    }


    private void ConvertToRPN(string infix)
    {
        string T = "";
        for (int i = 0; i < infix.Length; i++)
        {         
            if (infix[i] != ' ')
                T += infix[i];
            else
            {
                switch (T)
                {
                    case "(":
                        this.RPN_Stack.Push(T);
                        break;
                    case ")":
                        string x = "";
                        do
                        {
                            if(this.RPN_Stack.Count == 0)
                            {
                                FormatException error = new FormatException();
                                throw error;
                            }
                            x = this.RPN_Stack.Pop().ToString();
                            if (x != "(")
                                Output(ref x);
                        }
                        while (x != "(");
                        break;
                    case "+":
                    case "-":
                    case "x":
                    case "/":
                        while (this.RPN_Stack.Count != 0 && Priority(T) <= Priority(RPN_Stack.Peek().ToString()))
                        {
                            string pop = RPN_Stack.Pop().ToString();
                            Output(ref pop);
                        }
                        this.RPN_Stack.Push(T);
                        break;
                    default:
                        Output(ref T);
                        break;
                }
                T = "";
            }
        }
        while (this.RPN_Stack.Count != 0)
        {
            string pop = RPN_Stack.Pop().ToString();
            Output(ref pop);
        }
    }


    private bool CheckOperators(string infix)
    {
        char[] operators = { '+', '-', 'x', '/' };
        char[] operands_open = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '(' };
        char[] operands_close = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ')' };

        for (int i = 0; i <= 1; i++)
        {
            int y = infix.IndexOf(operators[i]);
            while (y != -1)
            {
                if (y < infix.Length - 2)
                {
                    if (!operands_open.Contains(infix[y + 2]))
                        return false;
                }
                else return false;
                y = infix.IndexOf(operators[i], y + 1);
            }
        }
        for (int i = 2; i <= 3; i++)
        {
            int y = infix.IndexOf(operators[i]);
            while (y != -1)
            {
                if (y > 1 && y < infix.Length - 3)
                {
                    if (!operands_open.Contains(infix[y + 2]) || !operands_close.Contains(infix[y - 2]))
                        return false;
                }
                else return false;
                y = infix.IndexOf(operators[i], y + 1);
            }
        }
        return true;
    }

    private void CheckSyntax(string infixInput)
    {
        if (!CheckOperators(infixInput))
        {
            FormatException error = new FormatException("SYNTAX ERROR");
            throw error;
        }
        else
        {
            this.RPN_Stack = new Stack();
            ConvertToRPN(infixInput);
        }
    }
}