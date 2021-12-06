# BlackJackCS

FAIL LEARN GROW REPEAT

DRY
assignment
Explorer Mode
General Rules:

    The game should be played with a standard deck of playing cards (52).
    The house should be dealt two cards, hidden from the player until the house reveals its hand.
    The player should be dealt two cards, visible to the player.
    The player should have a chance to hit (i.e. be dealt another card) until they decide to stop or they bust (i.e. their total is over 21). At which point they lose regardless of the dealer's hand.
    When the player stands, the house reveals its hand and hits (i.e. draw cards) until they have 17 or more.
    If dealer goes over 21 the dealer loses.
    The player should have two choices: "Hit" and "Stand."
    Consider Aces to be worth 11, never one.
    The app should display the winner. For this mode, the winner is who is closer to a blackjack (21) without going over.
    Ties go to the DEALER.
    There should be an option to play again. This should start a new game with a new full deck of 52 shuffled cards and new empty hands for the dealer and the player.

Adventure Mode

    Reveal one of the house's cards to the player when cards dealt.
    Consider aces be worth one or 11.
    Allow the player to "Split".
    Improve the win requirements. From Wikipedia:

^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

PEDAC
Problem
Create a shuffles deck of 52 cards
deal 2 card to a player and dealer from deck
Hide the dealers cards from player
player should have the chance to add another card until they decide stop or go over 21
Have dealer do the same sequence but must hit until >= 17 if dealer is over 21 then lose
Display if player or dealer is closer to or = 21 with tie going to dealer
then need to restart the game
optional
Reveal one dealer card and hide the other
Add a betting system that carries between rounds

EXAMPLE
dealer hand card + ? = dealer name hand = Jack of Spades ?
player hand card + card = Player hand = 2 of hearts and Jack of Hearts
DATA
loops classes and objects
objects
1Card
a.suit
b.rank
c.value

2Deck(not an object but a list populated with an object maybe) will need to be in a list/array to keep track of cards?
will need to shuffle
will need to populate and draw (remove cards)

3 (person) players and dealers
keep two cards
calculate the score of two cards and if the are busted

Algorithm
// \*create a deck of 52 cards
// Display greeting "Hi my name is {dealer name} Are you ready to play some Black Jack? Hit enter to start"
// Deal player two face up cards and display two cards for dealer one face up and one as ?
// on players turn player can choose to HIT or stand
// If HIT player is dealt another card to the hand
// sum of all card is added to determine if over 21
// if not over 21 player will be given the choice to hit or stand
// if over 21 displayed message You lose
// if player stands Then dealers turn
// on dealers turn Display both cards dealt earlier turn ? to a card
// The dealer will HIT until card score is great than or equal to 17 and then stand
// The value of the players hand and dealers hand will be compared to see which on is higher but less than 21
// Whichever hand is higher but not over 21 will be displayed in **\_** in the winner
// Question will be displayed would you like to play again
//
Code
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Mine^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
// # Data Structure

        // The following Nouns exist in the description of the "P"problem:

        // - Deck
        // - Card
        // - Hand
        // - Player
        // - Dealer

        // These have the following STATE (properties) and BEHAVIOR (methods)



        // - Card

        //   - Properties: The Face of the card, the Suit of the card
        //   - Behaviors:
        //     - The Value of the card according to the table in the "P"problem part

        // - Hand

        //   - Properties: A list of individual Cards
        //   - Behaviors:
        //     - TotalValue representing he sum of the individual Cards in the list.
        //       - Start with a total = 0
        //       - For each card in the hand do this:
        //         - Add the amount of that card's value to total
        //       - return "total" as the result
        //     - Add a card to the hand
        //       - Adds the supplied card to the list of cards

        // - Player is just an instance of the Hand class
        // - Dealer is just an instance of the Hand class
        // 1.  Create a new deck
        //     PEDAC ^^^^ - Properties: A list of 52 cards

// Algorithm for making a list of 52 cards

        //         Make a blank list of cards
        //         Suits is a list of "Club", "Diamond", "Heart", or "Spade"
        //         Faces is a list of 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King, or Ace
        //         ```
        //         Go through all of the suits one at a time and in order
        //         {
        //             Get the current suit
        //             Go through all of the faces one a time and in order
        //             {
        //                 Get the current face

        //                 With the current suit and the current face, make a new card
        //                 Add that card to the list of cards
        //             Go to the card and loop again
        //             }
        //         Go to the next suit and loop again
        //         }
        //         ```

        // 2.  Ask the deck to make a new shuffled 52 cards
        // 3.  Create a player hand
        // 4.  Create a dealer hand
        // 5.  Ask the deck for a card and place it in the player hand
            // - the card is equal to the 0th index of the deck list
            // - Remove the card from the deck list
            // - Call the "add card" behavior of the hand and pass it this card

        // 6.  Ask the deck for a card and place it in the player hand
        // 7.  Ask the deck for a card and place it in the dealer hand
        // 8.  Ask the deck for a card and place it in the dealer hand
        // 9.  Show the player the cards in their hand and the TotalValue of their Hand
            // - loop through the list of cards in the player hand for every card, print out
            // to the user the description of the card
        // 10. If they have BUSTED (hand TotalValue is > 21), then goto step 15
        // 11. Ask the player if they want to HIT or STAND
        // 12. If HIT
        //     - Ask the deck for a card and place it in the player hand, repeat step 10
        // 13. If STAND then continue on
        // 14. If the dealer's hand TotalValue is more than 21 then goto step 17
        // 15. If the dealer's hand TotalValue is less than 17
        //     - Add a card to the dealer hand and go back to 14
        // 16. Show the dealer's hand TotalValue
        // 17. If the player's hand TotalValue > 21 show "DEALER WINS"
        // 18. If the dealer's hand TotalValue > 21 show "PLAYER WINS"
        // 19. If the dealer's hand TotalValue is more than the player's hand TotalValue then show "DEALER WINS", else show "PLAYER WINS"
        // 20. If the value of the hands are even, show "DEALER WINS"

^^^^^^^^^^^^^^^^^^^^^^^^^^ instructors ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
