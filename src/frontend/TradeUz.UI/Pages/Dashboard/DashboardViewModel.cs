using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeUz.UI.Pages.Common;

namespace TradeUz.UI.Pages.Dashboard
{
    public partial class DashboardViewModel : BasePageViewModel
    {
        [ObservableProperty]
        private string _welcomeMessage = "AssalomuAlaykum";
        [ObservableProperty]
        private string _description = "Bu dashboard sahifasi";
    }
}
