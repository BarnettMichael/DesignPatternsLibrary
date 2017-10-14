using ChainOfResponsibility.Poker.Enums;
using System.Collections.Generic;

namespace ChainOfResponsibility.Poker.Categorizers
{
    class FullHouseCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            var seen = new Dictionary<Value, int>();

            foreach (Card c in hand.Cards)
            {
                if (seen.ContainsKey(c.Value))
                {
                    seen[c.Value]++;
                }
                else
                {
                    seen[c.Value] = 1;
                }
            }

            if (seen.Count == 2)
            {
                if (seen.ContainsValue(3) && seen.ContainsValue(2))
                {
                    return HandRanking.FullHouse;
                }
            }

            return Next.Catagorize(hand);
        }
    }
}

