using System;
namespace AbstractSyntaxTrees
{
    public enum BinaryOperator {
        Muliply,
        Add,
        Divide,
        Subtract,
    } 
    public class BinaryExpressionNode: ExpressionTreeNode
    {
        public ExpressionTreeNode Left { get; set; }
        public ExpressionTreeNode Right { get; set; }
        public BinaryOperator Operator { get; set; }

        public BinaryExpressionNode(ExpressionTreeNode left, BinaryOperator binaryOperator, ExpressionTreeNode right)
        {
            Left = left;
            Right = right;
            Operator = binaryOperator;
        }
    }
}
