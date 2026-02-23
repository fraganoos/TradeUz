using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using TradeUz.UI.Navigation;
using Microsoft.Extensions.DependencyInjection;
using System;
using TradeUz.UI.Pages.Dashboard;
using TradeUz.UI.Pages.Orders;
using TradeUz.UI.Shell;
using TradeUz.UI.Core;
using TradeUz.UI.Infrastructure.Theming;

namespace TradeUz.UI.App
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var provider = services.BuildServiceProvider();


            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var shell = provider.GetRequiredService<ShellView>();
                shell.DataContext = provider.GetRequiredService<ShellViewModel>();

                desktop.MainWindow = shell;

                var themeService = provider.GetRequiredService<IThemeService>();
                themeService.Initialize();

            }

            base.OnFrameworkInitializationCompleted();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddApplicationServices();

        }

        //private void SyncWithSystemTheme()
        //{
        //    if (Current is not { } app)
        //        return;
        //    // �������� ������� ���� �������
        //    app.RequestedThemeVariant = app.ActualThemeVariant;
        //}
    }
}