namespace Calculator.Services;

public class NCalcExpressionEvaluator : IExpressionEvaluator
{
    public object Evaluate(string expression)
    {
        var expr = new NCalc.Expression(expression);
        return expr.Evaluate();
    }
}
