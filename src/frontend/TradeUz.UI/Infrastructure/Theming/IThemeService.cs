using Avalonia.Styling;

public interface IThemeService
{
    ThemeVariant CurrentTheme { get; }

    void Initialize();
    void SetLight();
    void SetDark();
    void Toggle();
}