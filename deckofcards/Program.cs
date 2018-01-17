using System;
using System.Collections.Generic;

namespace deckofcards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello World!");
            // Deck of Cards
            // The goal of this assignment is to practice many of the OOP ideas we went over in the previous tabs. We will be constructing three different classes; Card, Deck, and Player, that should give us the base foundation for creating just about any card game we want! This is a very important assignment, as these concepts are the essentials to working with Classes, Objects, and their associated Methods All future lecture and assignments will continue to be built upon these concepts presented here as we continue through the course.
            Player player = new Player("Venkat");
            Deck deck = new Deck();
            PrintListOfCards("S1D ", deck.cards);
            deck.Deal();
            PrintListOfCards("S2D ", deck.cards);
            deck.Shuffle();
            PrintListOfCards("S3D ", deck.cards);
            for (int i = 0; i < 13; i++)
            {
                player.Draw(deck, false);
            }

            PrintListOfCards("S4D ", deck.cards);
            PrintListOfCards("S5H ", player.hand);

        }

        private static void PrintListOfCards(string info, List<Card> cards)
        {
            string str = "";
            foreach (var card in cards)
            {
                str += " " + card.CardImage();
            }
            Console.WriteLine(info + str);
        }
    }
}
