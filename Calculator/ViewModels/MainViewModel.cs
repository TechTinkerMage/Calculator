using Calculator.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calculator.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IExpressionEvaluator _evaluator;

    [ObservableProperty]
    private string expression = string.Empty;

    public MainViewModel()
    {
        _evaluator = new NCalcExpressionEvaluator();
    }

    [RelayCommand]
    private void Input(string value)
    {
        Expression += value;
    }

    [RelayCommand]
    private void Clear()
    {
        Expression = string.Empty;
    }

    [RelayCommand]
    private void Evaluate()
    {
        try
        {
            var result = _evaluator.Evaluate(Expression);
            Expression = result.ToString();
        }
        catch
        {
            Expression = "Error";
        }
    }
}
