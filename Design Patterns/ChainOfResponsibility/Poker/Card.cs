using ChainOfResponsibility.Poker.Enums;
using System;

namespace ChainOfResponsibility.Poker
{
    public class Card
    {
        public Suit Suit { get; private set; }
        public Value Value { get; private set; }

        public Card(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString()
        {
            return ValueToString() + SuitToString();
        }

        private string ValueToString()
        {
            switch (Value)
            {
                case Value.Two:
                    return "2";
                case Value.Three:
                    return "3";
                case Value.Four:
                    return "4";
                case Value.Five:
                    return "5";
                case Value.Six:
                    return "6";
                case Value.Seven:
                    return "7";
                case Value.Eight:
                    return "8";
                case Value.Nine:
                    return "9";
                case Value.Ten:
                    return "10";
                case Value.Jack:
                    return "J";
                case Value.Queen:
                    return "Q";
                case Value.King:
                    return "K";
                case Value.Ace:
                    return "A";
                default:
                    throw new NotImplementedException();
            }
        }

        private string SuitToString()
        {
            switch (Suit)
            {
                case Suit.Club:
                    return "C";
                case Suit.Heart:
                    return "H";
                case Suit.Diamond:
                    return "D";
                case Suit.Spade:
                    return "S";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
