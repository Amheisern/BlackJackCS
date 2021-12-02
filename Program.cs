using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    //   public enum CardSuit
    // {
    //     Hearts,
    //     Clubs,
    //     Diamonds,
    //     Spades
    // }

    // public enum CardValue
    // {
    //     Ace = 1,
    //     Two = 2,
    //     Three = 3,
    //     Four = 4,
    //     Five = 5,
    //     Six = 6,
    //     Seven = 7,
    //     Eight = 8,
    //     Nine = 9,
    //     Ten = 10,
    //     Jack = 10,
    //     Queen = 10,
    //     King = 10
    // }
    class card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public int CardValue { get; set; }
    }

    // class hand
    // {
    //     public string card { get; set; } = card.new (suit, Rank, CardValue);
    // }
    public class CardDeck
    {

    }
    class Program
    {

        //^^^^^^^^^^^^^^Classes^^^^^^^^^^^^^^^^^^^^    
        static void Main(string[] args)
        {

            // Algorithm B 
            // - Make a new list of the fours suits
            var suits = new List<string>() { "clubs", "diamonds", "hearts", "spades" };
            // - Make of a list of 13 ranks and call this list ranks
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            // - Make a new list of strings namer 'deck'
            var deck = new List<string>();
            // - Make a loop that goes through all the suits
            foreach (var suit in suits)
            {

                //   Make a loop that goes through all the 'ranks'
                //   add newly formed string to the end of the deck list - For Suit = Clubs
                foreach (var rank in ranks)
                {
                    var card = $"{rank} of {suit}";

                    deck.Add(card);
                }
            }
            var numberOfCards = deck.Count;
            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer"
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                // leftIndex = random integer >= 0 and < rightIndex
                //   Now swap the values at rightIndex and leftIndex by doing this:
                //   leftCard = the value from deck[leftIndex]
                var leftCard = deck[leftIndex];
                //   rightCard = the value from deck[rightIndex]
                var rightCard = deck[rightIndex];
                //   deck[rightIndex] = leftCard
                deck[rightIndex] = leftCard;
                //   deck[leftIndex] = rightCard
                deck[leftIndex] = rightCard;

            }
            foreach (var card in deck)
            {
                //  Console.WriteLine(card);
            }


            // - first card = deck[0]
            var firstcardB = deck[0] + deck[3];
            // - second card = deck[1]
            var secondcardB = deck[1];
            // - print first and second card  
            Console.WriteLine("firstcard: " + firstcardB);
            // Console.WriteLine("Secondcard: " + secondcardB);

            //Creating 1 hand (lists) of five cards and displaying the hands
            //var hand1 = deck[0][1];
            //This cannot be the best way of doing this, but i was failing at making a new list that would be better
            // populated with cards with a random index.  I don't have the time to spend on this now and 
            // will come back to it at some point.  Also need to figure out how to format text the way i want
            // Console.WriteLine("Player 1: " + deck[0] + deck[1] + deck[2] + deck[3] + deck[4]);
            // Console.WriteLine("Player 2: " + deck[5] + deck[6] + deck[7] + deck[8] + deck[9]);

            //var hand1 = deck[new List<string> = (2, 3, 4, 5)];

            Console.WriteLine("You have reach a save point");
        }
    }
}
