namespace TradeUz.UI.Core;

public class UserContext : IUserContext
{
    public bool IsAuthenticated { get; private set; }
    public string? Username { get; private set; }
    public string? Role { get; private set; }

    public void SetUser(string username, string role)
    {
        Username = username;
        Role = role;
        IsAuthenticated = true;
    }

    public void Logout()
    {
        Username = null;
        Role = null;
        IsAuthenticated = false;
    }
}