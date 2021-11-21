using System;
namespace AbstractSyntaxTrees
{
    public class ConstantNode : ExpressionTreeNode
    {
        public double Value { get; set; }
        public ConstantNode(double value)
        {
            Value = value;
        }

        public override double Evaluate() => Value;
    }
}
