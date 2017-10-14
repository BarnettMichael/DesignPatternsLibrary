using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Poker.Enums;

namespace ChainOfResponsibility.Poker.Categorizers
{
    class FourOfAKindCatagorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasNofKind(4, hand))
            {
                return HandRanking.FourOfAKind;
            }

            return Next.Catagorize(hand);
        }
    }
}
