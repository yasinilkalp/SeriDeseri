using Newtonsoft.Json;

namespace SeriDeseri
{
    public static class Extensions
    {
        public static string SerializeObject<T>(this T request)
        {
            return JsonConvert.SerializeObject(request);
        }

        public static T DeserializeObject<T>(this string request)
        {
            return JsonConvert.DeserializeObject<T>(request);
        }
    }
}
