namespace TradeUz.UI.Core;

public interface IUserContext
{
    bool IsAuthenticated { get; }
    string? Username { get; }
    string? Role { get; }
}