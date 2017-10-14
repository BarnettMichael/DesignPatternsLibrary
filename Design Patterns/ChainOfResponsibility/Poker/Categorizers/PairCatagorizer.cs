using ChainOfResponsibility.Poker.Enums;

namespace ChainOfResponsibility.Poker.Categorizers
{
    class PairCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasNofKind(2, hand))
            {
                return HandRanking.Pair; 
            }
            return Next.Catagorize(hand);
        }
    }
}
