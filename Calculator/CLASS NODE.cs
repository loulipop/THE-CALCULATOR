using System;

class node
{
    private node leftNode;
    private node rightNode;
    private string data;
    private double data_num;

    public node()
    {
        this.leftNode = null;
        this.rightNode = null;
        this.data = "";
        this.data_num = 0;
    }
    public node left
    {
        get { return this.leftNode; }
        set { this.leftNode = value; }
    }
    public node right
    {
        get { return this.rightNode; }
        set { this.rightNode = value; }
    }
    public string Data
    {
        get { return this.data; }
        set { this.data = value; }
    }

    public double Data_num
    {
        get { return this.data_num; }
        set { this.data_num = value; }
    }
}