using System.Collections.Generic;

namespace AdapterPattern.Model
{
    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}