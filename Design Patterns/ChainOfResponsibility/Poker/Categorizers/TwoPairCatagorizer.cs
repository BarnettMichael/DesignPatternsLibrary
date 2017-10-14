using ChainOfResponsibility.Poker.Enums;
using System.Collections.Generic;

namespace ChainOfResponsibility.Poker.Categorizers
{
    class TwoPairCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            var seen = new Dictionary<Value, int>();

            foreach (var card in hand.Cards)
            {
                if (seen.ContainsKey(card.Value))
                {
                    seen[card.Value]++;
                }
                else
                {
                    seen[card.Value] = 1;
                }
            }

            if (seen.Count == 3)
            {
                int twoSeen = 0;
                int oneSeen = 0;
                foreach (int val in seen.Values)
                {
                    switch (val)
                    {
                        case 1:
                            oneSeen++;
                            break;
                        case 2:
                            twoSeen++;
                            break;
                        default:
                            break;
                    }
                }

                if (oneSeen == 1 && twoSeen == 2)
                {
                    return HandRanking.TwoPair;
                }
            }

            return Next.Catagorize(hand);
        }
    }
}
