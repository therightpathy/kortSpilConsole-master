using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kortSpilConsole
{
    class Player
    {
        private UnoGame game;
        public List<Card> Hand { get; set; }
        private string navn;

        public Player(UnoGame game, string n)
        {
            this.game = game;
            this.navn = n;
            Hand = new List<Card>();
            DrawCard(7);
        }


        public void DrawCard()
        {
            //TODO spilleren tager et kort fra bunken op på hånden
            Card seCard;
            seCard = game.deck.Draw();
            Hand.Add(seCard);
        }

        public void DrawCard(int numberOfCards)
        {
            //TODO spileren tager n kort fra bunken op på hånden
            for (int i = 0; i < numberOfCards; i++)
            {
                Hand.Add(game.deck.Draw());
            }
        }

        public void showhand()
        {
            for (int i = 0; i < Hand.Count; i++)
            {
                Console.WriteLine(Hand[i]);
            }
        }

        public override string ToString()
        {
            string s = navn + ": ";
            for (int i = 0; i < Hand.Count; i++)
            {
                s += Hand[i].Color + Hand[i].Value;
            }
            return navn;
        }
        public StringBuilder //blablabalhsafhds
    }
}
