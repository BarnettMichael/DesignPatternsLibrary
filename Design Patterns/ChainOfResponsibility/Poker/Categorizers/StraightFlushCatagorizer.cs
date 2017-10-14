using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Poker.Enums;

namespace ChainOfResponsibility.Poker.Categorizers
{
    class StraightFlushCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasFlush(hand) && HasStraight(hand))
            {
                return HandRanking.StraightFlush;
            }

            return Next.Catagorize(hand);
        }
    }
}
