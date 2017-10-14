using ChainOfResponsibility.Poker.Enums;

namespace ChainOfResponsibility.Poker.Categorizers
{
    class HighCardCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            return HandRanking.HighCard;
        }
    }
}
