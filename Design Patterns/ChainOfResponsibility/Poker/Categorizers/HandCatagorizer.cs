using ChainOfResponsibility.Poker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Poker.Categorizers
{
    abstract class HandCatagorizer
    {
        public HandCatagorizer RegisterNext(HandCatagorizer next)
        {
            Next = next;
            return Next;
        }

        protected HandCatagorizer Next { get; private set; }
        public abstract HandRanking Catagorize(Hand hand);

        protected static bool HasNofKind(int n, Hand hand)
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

            foreach (var count in seen.Values)
            {
                if (count == n)
                {
                    return true;
                }
            }

            return false;
        }
        protected static bool HasStraight(Hand hand)
        {
            List<Value> values = hand.Cards.Select(c => c.Value).ToList();
            values.Sort();

            int expectedValue = (int)values[0];

            foreach (Value value in values)
            {
                if ((int)value != expectedValue)
                {
                    return false;
                }

                expectedValue++;
            }

            return true;
        }
        protected static bool HasFlush(Hand hand)
        {
            List<Suit> suits = hand.Cards.Select(c => c.Suit).ToList();
            suits.Sort();

            Suit expected = suits[0];

            return suits.All(suit => suit == expected);
        }
    }
}
