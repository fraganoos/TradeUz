using CommunityToolkit.Mvvm.ComponentModel;

namespace TradeUz.UI.Navigation;

public class Router: ObservableObject, IRouter
{
    private object? _current;
    public object? Current
    {
        get => _current;
        private set => SetProperty(ref _current, value);
    }

    public void SetCurrent(object viewModel)
    {
        Current = viewModel;
    }
}