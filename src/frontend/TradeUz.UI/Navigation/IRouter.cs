namespace TradeUz.UI.Navigation;

public interface IRouter
{
    object? Current { get; }
    void SetCurrent(object viewModel);
}