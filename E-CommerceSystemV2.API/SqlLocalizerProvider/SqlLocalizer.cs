using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Serilog;

namespace E_CommerceSystemV2.API.SqlLocalizerProvider
{
    public class SqlLocalizer : IStringLocalizer
    {
        private readonly ECommerceContext _ecommerceContext;

        public SqlLocalizer(ECommerceContext eCommerceContext)
        {
            _ecommerceContext = eCommerceContext;
        }

       public LocalizedString this[string name] => new LocalizedString(name,GetLocalizedString(name)); /*Suitable for basic scenarios where you mainly need to retrieve individual localized strings without much formatting.*/


        public LocalizedString this[string name, params object[] arguments] => throw new NotImplementedException(); /*Suitable for projects with a large number of dynamic or frequently changing localized strings*/

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
       {
            throw new NotImplementedException();
        } /* Suitable for projects with a mix of static and dynamic content */

        public string GetLocalizedString(string key )
        {
           var language = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            var q1 = _ecommerceContext.Textsss
                .Where(t => t.TextKey == key);
            IQueryable<string> messages = language switch
            {
                "en" => q1.Select(a => a.EnglishText),
                "ar" => q1.Select(a => a.ArabicText),
                  _=>q1.Select(a=>a.EnglishText)
            };

            var retrievedMessage = messages.FirstOrDefault();

            Log.Error($"Key: {key}, Language: {language}, Retrieved Message: {retrievedMessage}");

            return retrievedMessage ?? key;
        }
        
    }
}
