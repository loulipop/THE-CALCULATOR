using System;
using System.Collections.Generic;
using System.Collections;

class BinaryTree
{
    private node root;
    private string result;

    public node Root
    {
        get { return this.root; }
        set { this.root = value; }
    }
    public string Result
    {
        get { return this.result; }
        set { this.result = value; }
    }
    public BinaryTree(RPN RPN_Input)
    {
        this.root = new node();
        result = "";
        string rpn_result = RPN_Input.Result;
        int index = rpn_result.Length - 1;
        Input(ref rpn_result, ref index, this.Root);
        return;
    }
    private void Input(ref string dataInput, ref int index, node presentNode)
    {
        if (index < 0)
            return;
        string input = "";
        while (index >= 0 && dataInput[index] != ' ')
        {
            input += dataInput[index];
            index--;
        }
        index--;
        char[] reverse = input.ToCharArray();
        Array.Reverse(reverse);
        input = new string(reverse);
        presentNode.Data = input;
        switch (input)
        {
            case "+":
            case "-":
            case "x":
            case "/":
                presentNode.right = new node();
                Input(ref dataInput, ref index, presentNode.right);
               
                presentNode.left = new node();
                Input(ref dataInput, ref index, presentNode.left);
                break;
            default:
                presentNode.Data_num = double.Parse(input);
                break;
        }
        return;
    }

    

    private void Calculate(node presentNode)
    {
        switch (presentNode.Data)
        {
            case "+":
            case "-":
            case "x":
            case "/":
                Calculate(presentNode.left);
                double left = presentNode.left.Data_num;
                Calculate(presentNode.right);
                double right = presentNode.right.Data_num;

                switch (presentNode.Data)
                {
                    case "+":
                        presentNode.Data_num = left + right;
                        return;
                    case "-":
                        presentNode.Data_num = left - right;
                        return;
                    case "x":
                        presentNode.Data_num = left * right;
                        return;
                    case "/":
                        if (right == 0)
                        {
                            DivideByZeroException error = new DivideByZeroException();
                            throw error;
                        }
                        presentNode.Data_num = left / right;
                        return;
                }
                break;
            case "":
                return;
        }

    }

    public void Calculate()
    {
        Calculate(this.root);
        this.result = this.Root.Data_num.ToString();
    }

}


