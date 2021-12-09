using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void PlayTheGame()
        {
            // creates a new deck to start the game
            var deck = new Deck();
            // 3.  Create a player hand
            var player = new Hand();
            // 4.  Create a dealer hand
            var dealer = new Hand();
            // 5.  Ask the deck for a card and place it in the player hand
            // - the card is equal to the 0th index of the deck list
            // - loops twice to deal two cards
            for (var numberOfCardsToDeal = 0; numberOfCardsToDeal < 2; numberOfCardsToDeal++)
            {
                deck.DealCard(player);
            }
            // 6.  Ask the deck for a card and place it in the player hand
            for (var numberOfCardsToDeal = 0; numberOfCardsToDeal < 2; numberOfCardsToDeal++)
            {
                deck.DealCard(dealer);
            }
            // 9.  Show the player the cards in their hand and the TotalValue of their Hand
            // - loop through the list of cards in the player hand for every card, print out
            // to the user the description of the card

            // var secondPlayerCard = deck.Cards[0];
            // deck.Cards.Remove(secondPlayerCard);
            // player.AddCard(secondPlayerCard);
            //10. If they have BUSTED (hand TotalValue is > 21)
            var answer = "";
            while (player.HandValue() <= 21 && (answer != "STAND"))
            {
                // 9.  Show the player the cards in their hand and the TotalValue of their Hand
                // - loop through the list of cards in the player hand for every card, print out
                // to the user the description of the card
                player.PrintCardsandTotal("player");
                // 11. Ask the player if they want to HIT or STAND
                Console.WriteLine("Would you like to HIT or STAND");
                answer = Console.ReadLine().ToUpper();
                // 12. If HIT
                if (answer == "HIT")
                {
                    deck.DealCard(player);
                    // //     - Ask the deck for a card and place it in the player hand, repeat step 10
                    // var card = deck.Cards[0];
                    // // - Remove the card from the deck list
                    // deck.Cards.Remove(card);
                    // // - Call the "add card" behavior of the hand and pass it this card
                    // player.AddCard(card);
                    // //  player.DealCard(card);
                }

                //     - Ask the deck for a card and place it in the player hand, repeat step 10
                // 13. If STAND then continue on
            }
            player.PrintCardsandTotal("player");
            //14. If the dealer's hand TotalValue is more than 21 then goto step 17
            //15. If the dealer's hand TotalValue is less than 17
            while (player.HandValue() <= 21 && dealer.HandValue() <= 17)
            {

                deck.DealCard(dealer);
                // var card = deck.Cards[0];
                // deck.Cards.Remove(card);
                // dealer.AddCard(card);
            }
            dealer.PrintCardsandTotal("Dealer");
            // 17. If the player's hand TotalValue > 21 show "DEALER WINS"
            if (player.Busted())
            {
                Console.WriteLine("Dealer Wins");
            }
            // 18. If the dealer's hand TotalValue > 21 show "PLAYER WINS"
            else
            if (dealer.Busted())
            {
                Console.WriteLine("Player Wins");
            }
            // 19. If the dealer's hand TotalValue is more than the player's
            // hand TotalValue then show "DEALER WINS", else show "PLAYER WINS"
            else
            if (player.HandValue() > dealer.HandValue())
            {
                Console.WriteLine("Player Wins");
            }
            else
            if (player.HandValue() < dealer.HandValue())
            {
                Console.WriteLine("dealer Wins");
            }
            // 20. If the value of the hands are even, show "DEALER WINS"
            else
            {
                Console.WriteLine("Dealer Wins");
            }

        }
        // Card
        // Class for the cards, and also establishes value for the cards 
        //TotalValue representing the sums of the individual cards in 
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
                Shuffle();
            }

            public void DealCard(Hand hand)
            {
                var card = Cards[0];
                // - Remove the card from the deck list
                Cards.Remove(card);
                // - Call the "add card" behavior of the hand and pass it this card
                hand.AddCard(card);
                Console.WriteLine(card);
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
            public void AddCard(Card cardToAdd)
            {

                CurrentCards.Add(cardToAdd);
            }
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
            public void PrintCardsandTotal(string handName)
            {
                Console.WriteLine($"{handName}, your cards are:");
                //Console.WriteLine(string.Join(", "player.CurrentCards));
                foreach (var card in CurrentCards)
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine(card);
                    Console.WriteLine("-------------");
                }
                Console.WriteLine($"The total value of the cards are {HandValue()}");

            }
            public Boolean Busted()
            {
                return HandValue() > 21;
                // if (HandValue() > 21)
                // {
                //     return true;
                // }
                // else
                // {
                //     return false;
                // }
            }

        }

        //^^^^^^^^^^^^^^^^^^^^^^ CLASSES ^^^^^^^^^^^^^^^^^^^^^^^^^^^

        static void Main(string[] args)
        {
            while (true)
            {
                PlayTheGame();
                Console.WriteLine("would you like to play again. If yes then type YES! If no then type NO");
                var answer = Console.ReadLine().ToUpper();
                if (answer == "NO")
                {
                    Console.WriteLine("Thanks for playing");
                    break;
                }

            }
        }



    }


}