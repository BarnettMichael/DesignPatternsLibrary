using BridgePattern.Interfaces;
namespace BridgePattern.Formatters
{
    public class FancyFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"-= {key} ------- =- {value}";
        }
    }
}
