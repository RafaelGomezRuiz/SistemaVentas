using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SistemaVentas.Core.Application.Dtos.Account;

namespace SistemaVentas.Core.Application.Helpers
{
    public static class JsonHelper
    {

        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
