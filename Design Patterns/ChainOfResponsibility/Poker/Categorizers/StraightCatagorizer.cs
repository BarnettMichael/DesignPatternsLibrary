using ChainOfResponsibility.Poker.Enums;

namespace ChainOfResponsibility.Poker.Categorizers
{
    class StraightCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasStraight(hand))
            {
                return HandRanking.Straight;
            }

            return Next.Catagorize(hand);
        }
    }
}
