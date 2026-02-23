
namespace TradeUz.UI.Navigation
{
    public interface INavigationService
    {
        void NavigateTo<T>() where T : class;
    }
}
