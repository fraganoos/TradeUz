using System;
using System.Collections.Generic;
using TradeUz.UI.Pages.Dashboard;
using TradeUz.UI.Pages.Orders;

namespace TradeUz.UI.Navigation;

public static class NavigationRegistry
{
    public static readonly Dictionary<string, Type> Pages = new()
    {
        { "Dashboard", typeof(DashboardViewModel) },
        { "Orders", typeof(OrdersViewModel) }
    };
}