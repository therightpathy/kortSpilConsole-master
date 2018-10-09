﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kortSpilConsole
{
    class Deck
    {
        private List<Card> cards = new List<Card>();
        private List<Card> cardsRevealed = new List<Card>();
        private UnoGame game;

        public Deck(UnoGame game)
        {
            this.game = game;
            for (int i = 0; i < 10; i++)
            {
                // red cards
                cards.Add(new Card("red", i));
                cards.Add(new Card("red", i));
                //blue cards
                cards.Add(new Card("blue", i));
                cards.Add(new Card("blue", i));
                //green cards
                cards.Add(new Card("green", i));
                cards.Add(new Card("green", i));
                //yellow cards
                cards.Add(new Card("yellow", i));
                cards.Add(new Card("yellow", i));
            }

            Shuffle();

            //move first card to revealed cards
            cardsRevealed.Add(Draw());
        }
        
        public Card Draw()
        {
            Card c = cards[0]; //finder øverste kort
            cards.Remove(c); //fjerner kort fra bunken (c = øverste kort)
            return c; //giver kortet til den der kalder metoden
        }

        public Card peek()
        {
            return cardsRevealed.Last();
        }

        public void Shuffle()
        {
            // shuffle array
            Random random = new Random();
            cards = cards.OrderBy(x => random.Next()).ToList();
        }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cards.Count; i++)
            {
                sb.Append("[");
                sb.Append(cards[i]);
                sb.Append("], ");
            }

            return sb.ToString();
        }

        public Card Peek()
        {
            return cardsRevealed.Last();
        }
    }
}
