using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;

namespace redisclient
{
    public class Card
    {
        public String Face { get; set; }
        public String Suit { get; set; }

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public Card(string value)
        {
            Face = value.Substring(0, 1);
            Suit = value.Substring(1, 1);
        }

        public override string ToString()
        {
            return $"{Face}{Suit}";
        }
    }
}
