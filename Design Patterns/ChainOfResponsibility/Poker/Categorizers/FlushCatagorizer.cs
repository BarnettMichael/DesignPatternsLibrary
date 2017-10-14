using ChainOfResponsibility.Poker.Enums;

namespace ChainOfResponsibility.Poker.Categorizers
{
    class FlushCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasFlush(hand))
            {
                return HandRanking.Flush;
            }
            return Next.Catagorize(hand);
        }
    }
}
