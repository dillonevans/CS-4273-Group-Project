using System;
namespace AbstractSyntaxTrees
{
    public class ConstantNode
    {
        public double Value { get; set; }
        public ConstantNode(double value)
        {
            Value = value;
        }
    }
}
