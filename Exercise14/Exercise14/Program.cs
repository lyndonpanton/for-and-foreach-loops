using ConsoleCards;

namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // problem 1
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();

            deck.Shuffle();

            // problem 2
            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            foreach (Card card in hand)
            {
                card.FlipOver();
            }

            foreach(Card card in hand)
            {
                card.Print();
            }
        }
    }
}