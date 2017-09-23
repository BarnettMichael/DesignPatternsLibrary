using BridgePattern.Interfaces;
using System.Linq;

namespace BridgePattern.Formatters
{
    public class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{new string(key.Reverse().ToArray())}: {new string(value.Reverse().ToArray())}";
        }
    }
}
