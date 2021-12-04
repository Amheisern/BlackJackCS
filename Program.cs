using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        // Card
        // Class for the cards, and also establishes value for the cards 
        public class Card
        {
            public string Suit { get; set; }

            public string Rank { get; set; }

            public int Value()
            {
                // if 2-10 --> value = 2-10
                if (Rank == "2")
                {
                    return 2;
                }
                if (Rank == "3")
                {
                    return 3;
                }
                if (Rank == "4")
                {
                    return 4;
                }
                if (Rank == "5")
                {
                    return 5;
                }
                if (Rank == "6")
                {
                    return 6;
                }
                if (Rank == "7")
                {
                    return 7;
                }
                if (Rank == "8")
                {
                    return 8;
                }
                if (Rank == "9")
                {
                    return 9;
                }
                // if J, Q, K --> value = 10
                if (Rank == "10" || Rank == "Jack" || Rank == "Queen" || Rank == "King")
                {
                    return 10;
                }
                // if Ace --> value = 11
                if (Rank == "Ace")
                {
                    return 11;
                }

                return 0;
            }

            public override string ToString()
            {
                return $"{Rank} of {Suit}";
            }
        }

        // - Deck
        class Deck
        {
            //   - Properties: A list of 52 cards
            public List<Card> Cards { get; set; } = new List<Card>();

            public Deck()
            {
                //   - Behavior: Make a new deck of 52 shuffled cards. Deal one card out of the deck.
                // CreateDeck is a conditional method
                // Shuffle is a method to shuffle the created deck using fisher yates
                CreateDeck();
                Shuffle();
            }

            public void CreateDeck()
            {
                // - Make a new list of the fours suits
                var suits = new List<string>() { "clubs", "diamonds", "hearts", "spades" };
                // - Make of a list of 13 ranks and call this list ranks
                var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
                // - Make a new list of strings namer 'deck'
                // var deck = new List<string>();
                // - Make a loop that goes through all the suits
                foreach (var suit in suits)
                {
                    //   Make a loop that goes through all the 'ranks'
                    //   add newly formed string to the end of the deck list - For Suit = Clubs
                    foreach (var rank in ranks)
                    {
                        var card = new Card()
                        {
                            Suit = suit,
                            Rank = rank
                        };
                        Cards.Add(card);
                    }

                }

            }
            public void Shuffle()
            {
                // Fisher Yates shuffle imported from previous assignment
                var numberOfCards = Cards.Count;
                for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
                {
                    //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer"
                    var randomNumberGenerator = new Random();
                    var leftIndex = randomNumberGenerator.Next(rightIndex);
                    // leftIndex = random integer >= 0 and < rightIndex
                    //   Now swap the values at rightIndex and leftIndex by doing this:
                    //   leftCard = the value from deck[leftIndex]
                    var leftCard = Cards[leftIndex];
                    //   rightCard = the value from deck[rightIndex]
                    var rightCard = Cards[rightIndex];
                    //   deck[rightIndex] = leftCard
                    Cards[rightIndex] = leftCard;
                    //   deck[leftIndex] = rightCard
                    Cards[leftIndex] = rightCard;
                }
            }
        }

        // - Hand
        class Hand
        {
            //   - Properties: A list of individual Cards
            public List<Card> CurrentCards { get; set; } = new List<Card>();
            //   - Behaviors:
            //     - TotalValue representing he sum of the individual Cards in the list.
            public int HandValue()
            {
                //       - Start with a total = 0
                var sum = 0;
                //       - For each card in the hand do this:
                //         - Add the amount of that card's value to total
                foreach (var card in CurrentCards)
                {
                    sum = sum + card.Value();
                }

                return sum;
            }
        }


        static void Main(string[] args)
        {
            // creates a new deck to start the game
            var deck = new Deck();
            // foreach (var card in deck.Cards)
            // {
            //     Console.WriteLine($"{card}: {card.Value()}");

            // }

            var playerhand = new Hand();
            // Initial Hand
            playerhand.CurrentCards.Add(deck.Cards[0]);
            playerhand.CurrentCards.Add(deck.Cards[1]);
            // Stand
            // done --> look at dealer's hand
            Console.WriteLine(playerhand.HandValue());
            // Console.WriteLine("------------------------");
            // Console.WriteLine(playerhand[0].Value() + playerhand[1].Value());


            // Hit
            // playerhand.Add(deck.Cards[2]);

        }

    }


}