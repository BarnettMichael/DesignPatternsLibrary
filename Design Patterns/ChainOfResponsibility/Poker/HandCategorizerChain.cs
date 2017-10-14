using ChainOfResponsibility.Poker.Categorizers;
using ChainOfResponsibility.Poker.Enums;

namespace ChainOfResponsibility.Poker
{
    class HandCategorizerChain
    {
        private HandCategorizerChain()
        {
            head = new RoyalFlushCatagorizer();
            head.RegisterNext(new StraightFlushCatagorizer())
                .RegisterNext(new FourOfAKindCatagorizer())
                .RegisterNext(new FullHouseCatagorizer())
                .RegisterNext(new FlushCatagorizer())
                .RegisterNext(new StraightCatagorizer())
                .RegisterNext(new ThreeOfAKindCatagorizer())
                .RegisterNext(new TwoPairCatagorizer())
                .RegisterNext(new PairCatagorizer())
                .RegisterNext(new HighCardCatagorizer());
        }

        public static HandRanking GetRank(Hand hand)
        {
            return _instance.head.Catagorize(hand);
        }

        private HandCatagorizer head { get; set; }
        private static readonly HandCategorizerChain _instance = new HandCategorizerChain();
    }
}
