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

       public LocalizedString this[string name] => new LocalizedString(name,GetLocalizedString(name,"en")); /*Suitable for basic scenarios where you mainly need to retrieve individual localized strings without much formatting.*/


        public LocalizedString this[string name, params object[] arguments] => throw new NotImplementedException(); /*Suitable for projects with a large number of dynamic or frequently changing localized strings*/

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
       {
            throw new NotImplementedException();
        } /* Suitable for projects with a mix of static and dynamic content */

        public string GetLocalizedString(string key , string language )
        {

            string retrievedMessage;

            switch (language)
            {
                case "ar":
                    retrievedMessage = _ecommerceContext.Textsss
                        .Where(t => t.TextKey == key)
                        .Select(t => t.ArabicText)
                        .FirstOrDefault()!;
                 break;

                case "en":
                    retrievedMessage = _ecommerceContext.Textsss
                        .Where(t => t.TextKey == key)
                        .Select(t => t.EnglishText)
                        .FirstOrDefault()!;
                break;

                default:
                    retrievedMessage = _ecommerceContext.Textsss
                        .Where(t => t.TextKey == key)
                        .Select(t => t.EnglishText)
                        .FirstOrDefault()!;
                    break;

            }
            Log.Error($"Key: {key}, Language: {language}, Retrieved Message: {retrievedMessage}");

            return retrievedMessage;

        }

    }
}
