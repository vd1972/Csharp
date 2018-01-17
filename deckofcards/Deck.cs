using System;
using System.Collections.Generic;

public class Deck
{
     public List<Card> cards;
     private Random rand;
     private char [] decType = {'♦', '♣', '♠', '♥'};
     public Deck()
    {
        CreateDeck();
    }

    private void CreateDeck()
    {
        rand = new Random();
        cards = new List<Card>();
        for (int i = 0; i < decType.Length; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                cards.Add(new Card(decType[i], j));
            }
        }
    }

    public Card Deal()
     {
         int cardLocation = cards.Count-1;
         Card card = cards[cardLocation];
         cards.RemoveAt(cardLocation);
         return card;
     }

     public void Reset()
     {
         CreateDeck();
     }

     public void Shuffle()
     {
         Card currCard;
         int randLoc;
         //Console.WriteLine("total cards count " + cards.Count);
         for (int i = 0; i < cards.Count; i++)
         {
            randLoc = rand.Next(0, 51);
            //Console.WriteLine("Shuffle location " + randLoc);
            currCard = cards[randLoc];
            cards.RemoveAt(randLoc);
            cards.Add(currCard);
         }
     }

     public Card GetACardFromDeck()
     {
         int randLoc = rand.Next(0, cards.Count);
         Card selectedCard = cards[randLoc];
         cards.RemoveAt(randLoc);
         return selectedCard;
     }
    // Next, create a class called "Deck"
    // Give the Deck class a property called "cards" which is a list of Card objects
    // When initializing the deck make sure that it has a list of 52 unique cards as its "cards" property
    // Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card
    // Give the Deck a reset method that resets the cards property to the contain the original 52 cards
    // Give the Deck a shuffle method that randomly reorders the deck's cards
    // Finally, create a class called "Player"
}