using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace JohanBos.Data
{
    internal static class Data
    {
        public static async Task<string> GetResource(string name)
        {
            var assembly = typeof(Data).GetTypeInfo().Assembly;
            var fullName = $"JohanBos.Data.Data.{name}.json";
            var stream = assembly.GetManifestResourceStream(fullName);
            using (var streamReader = new StreamReader(stream))
            {
                return await streamReader.ReadToEndAsync().ConfigureAwait(false);
            }
        }
    }
}