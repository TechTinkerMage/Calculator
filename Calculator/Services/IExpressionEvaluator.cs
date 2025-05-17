namespace Calculator.Services;

public interface IExpressionEvaluator
{
    object Evaluate(string expression);
}
