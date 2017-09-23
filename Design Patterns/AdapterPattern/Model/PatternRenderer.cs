using System.Collections.Generic;

namespace AdapterPattern.Model
{
    public class PatternRenderer
    {
        private IDataPatternRendererAdapter dataPatternRenderer;

        public PatternRenderer(IDataPatternRendererAdapter dataPatternRenderer) => this.dataPatternRenderer = dataPatternRenderer;
        public PatternRenderer() : this(new DataPatternRendererAdapter()) { }
        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return dataPatternRenderer.ListPatterns(patterns);
        }
    }
}
