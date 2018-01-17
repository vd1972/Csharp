using System;
using System.Collections.Generic;

public class Player
{
    private string name;
    public List<Card> hand;
    private Random rand;
    // Give the Player class a name property
    // Give the Player a hand property that is a List of type Card
    // Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card
    // Note this method will require reference to a deck object
    // Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.
    public Player(string playerName)
    {
        name = playerName;
        hand = new List<Card>();
        rand = new Random();
    }

    public Card Draw(Deck deck, bool discard)
    {
        hand.Add(deck.GetACardFromDeck());
        if (discard)
           return Discard(rand.Next(0, hand.Count));
        else
           return null;
    }

    public Card Discard(int i)
    {
        try
        {
            Card selectedCard = hand[i];
            hand.RemoveAt(i);
            return selectedCard;
        }
        catch
        {
            return null;
        }

    }
}