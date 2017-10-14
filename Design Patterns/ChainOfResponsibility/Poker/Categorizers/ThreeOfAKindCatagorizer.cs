using ChainOfResponsibility.Poker.Enums;

namespace ChainOfResponsibility.Poker.Categorizers
{
    class ThreeOfAKindCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            return HandRanking.ThreeOfAKind;
        }
    }
}
