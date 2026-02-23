namespace TradeUz.UI.Infrastructure.Storage;

public interface ILocalSettingsService
{
    void Save<T>(string key, T value);
    T? Load<T>(string key);
}

