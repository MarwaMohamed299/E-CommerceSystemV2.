
using E_CommerceSystemV2.DAL.Data.Models;
using Microsoft.Extensions.Localization;
using Serilog;


namespace E_CommerceSystemV2.API.SqlLocalizerProvider;

public class SqlLocalizer : IStringLocalizer
{
    private readonly ECommerceContext _ecommerceContext;

    public SqlLocalizer(ECommerceContext eCommerceContext)
    {
        _ecommerceContext = eCommerceContext;
    }

    public LocalizedString this[string name] =>  new LocalizedString(name,GetLocalizedString(name));


    public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
    {
        throw new NotImplementedException();
    }

    public string GetLocalizedString(string key)
    {
       var language = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
       var q1 = _ecommerceContext.Textsss
            .Where(t => t.TextKey == key);
        IQueryable<string> messages = language switch
        {
            "ar" => q1.Select(a => a.ArabicText),
            "en" => q1.Select(a => a.EnglishText),
              _=>q1.Select(a=>a.EnglishText)
        };

        var retrievedMessage = messages.FirstOrDefault();

        Log.Error($"Key: {key}, Language: {language}, Retrieved Message: {retrievedMessage}");

        return retrievedMessage ?? key;
    }


    public LocalizedString this[string name, params object[] arguments]
    {
        get
        {
            string localizedMessage = GetLocalizedString(name);

            if (arguments.Length > 0 && arguments[0] is string email)
            {
                var user = GetUserFromDatabase(email);

                if (user != null)
                {
                    localizedMessage = string.Format(localizedMessage, user.UserName, user.PasswordHash);
                    Log.Information($"Formatted Message: {localizedMessage}");
                }
                else
                {
                    Log.Warning($"User not found for email: {email}");
                }
            }
            return new LocalizedString(name, localizedMessage);
        }
    }
    public User? GetUserFromDatabase(string email)
    {
        return _ecommerceContext.Users
            .Where(e => e.Email == email)
            .SingleOrDefault();
    }
}
