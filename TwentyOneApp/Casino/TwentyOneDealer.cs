using System.Collections.Generic;

namespace Casino
{
    public class TwentyOneDealer : Dealer
    {
        public List<Card> Hand { get; set; } = new List<Card>();
        public bool Stay { get; set; }
        public bool IsBusted { get; set; }
    }
}
