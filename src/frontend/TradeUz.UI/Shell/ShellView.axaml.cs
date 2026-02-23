using Avalonia.Controls;
using Avalonia.Styling;
using TradeUz.UI.Infrastructure;
using System;

namespace TradeUz.UI.Shell
{
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
        }

        private void Image_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
        {
            if (e.ClickCount != 2)
                return;
            (DataContext as ShellViewModel)?.SideMenuResizeCommand?.Execute(null);
        }
    }
}