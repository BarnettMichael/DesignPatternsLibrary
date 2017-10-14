using ChainOfResponsibility.Poker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Poker
{
    class Hand
    {
        private readonly List<Card> _cards = new List<Card>();
        private HandRanking _rank = HandRanking.Unknown;

        public void Add(Card card)
        {
            if (_cards.Count >= 5)
            {
                throw new InvalidOperationException("Cannot add more than 5 cards to a hand.");
            }

            _cards.Add(card);

            if (_cards.Count == 5)
            {
                _rank = HandCategorizerChain.GetRank(this);
            }
        }

        public Card HighCard
        {
            get
            {
                if (_cards.Count == 0)
                {
                    throw new InvalidOperationException();
                }
                return _cards.Last();
            }
        }

        public IEnumerable<Card> Cards => _cards;
        public HandRanking Rank => _rank;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Card c in _cards)
            {
                sb.AppendFormat($"{c} ");
            }

            return sb.ToString();
        }
    }
}
