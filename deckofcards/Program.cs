using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    //Properties
    //To the user of an object, a property appears to be a field, accessing the property requires the same syntax.
    //To the implementer of a class, a property is one or two code blocks, representing a get accessor and/or a set accessor.

    //Properties are declared in the class block by specifying the access level of the field, 
    //followed by the type of the property, followed by the name of the property, 
    //and followed by a code block that declares a get-accessor and/or a set accessor. For example:


    // Give the Card class a property "val" which will hold the value of the card (A, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K). This "val" should be a String
    // Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds)
    // Give the Card a property "numerical_val" which will hold the numerical value of the card 1-13 as integers
    public class Card
    {
        //card is an attribute here, along with suit and numerical_val
        //Constructors have the same name as the class or struct, and they usually initialize the data members of the new object.
        //This class is then instantiated with the new operator.
        //These are 
        public string val { get; set; }
        public string suit { get; set; }
        public int numerical_val {get; set;}
        
        //This is the Constructor, same name as class.
        public Card(string cardval, string suitval, int numerical_val_value)
        {
            val = cardval;
            suit = suitval;
            numerical_val = numerical_val_value;
            
        }


    }

    //1 Give the Deck class a property called "cards" which is a list of Card objects
    //2 When initializing the deck make sure that it has the 52 unique cards in its "cards" property
    //3 Give the Deck a deal method that selects the "top-most" card, removes it, and returns it
    //4 Give the Deck a reset method that resets the cards property to the contain the original 52 cards
    //5 Give the Deck a shuffle method that randomly reorders the deck's cards

    public class Deck
    {
        public List<string> cards = new List<string>(52);
        public List<Card> cardDeck { get; set; }
        public Deck(List<string> newcards)
        {
            for(int i = 0; i < 52; i++)
            {
                for(int j = 0; j < 52; j++)
                {
                    if(newcards[j].Contains(cards[i]))
                    {
                        newcards.Remove(cards[i]);
                    }
                    else
                    {
                        newcards.Add(cards[i]);
                    }
                }
            }
        }
        public string topcards(string topcard)
        {
            topcard = cards[52];
            cards.RemoveAt(52);
            return topcard;
        }

        public void reset()
        {
            List<string> cards = new List<string>(52);
        }
        
        //TODO
        public void shuffle(List<string> cards)
        {
            cards = new List<string>(52);
            Random rnd = new Random();
            int num;
            for(int i = 0; i < 53; i++)
            {
                num = rnd.Next(0,51);
                if(cards[i].Contains(cards[num]))
                {
                    rnd.Next(0, 51 - i);
                }
            }
        }

    //1 Give the Player class a name property
    //2 Give the Player a hand property of type [Card]
    //3 Give the Player a draw method of type (Deck) -> Card which draws a card from a deck, adds it to the player's hand, and returns it
    //  Note how we are passing the Deck by reference here since it is a class. 
    //4  Give the Player a discard method of type (Card) -> Bool which discards the Card specified and returns True if the Card existed and was successfully removed or False if the Card was not in the player's hand.
    public class Player
    {
        //If we wanted to pass a variable to this object when creating it to change some of its attributes
        public string name;
        Card cards2 = new Card("ace","something",5);
    }
        // List Examples
        // List<string> list4 = new List<string>(3);
        // list4.Add(null); // Add empty references. (BAD)
        // list4.Add(null);
        // list4.Add(null);
        // list4[0] = "carrot"; // Assign those references.
        // list4[1] = "fox";
        // list4[2] = "explorer";

        
        // Use Add method for each element.
        // List<string> list5 = new List<string>();
        // list5.Add("carrot");
        // list5.Add("fox");
        // list5.Add("explorer");

        // cards.Add("Ace")
        // Console.WriteLine(cards[2]);
        // Console.WriteLine(" We know {0} man.", cards.Count);
        
        // for (var idx = 0; idx < bikes.Count; idx++)
        // {
        // Console.WriteLine("-" + bikes[idx]);
        // }

        // bikes.Insert(2, "Yamaha");
        //Removal from Generic List
        //Remove is a lot like Javascript array pop, but searches for a specified value
        //In this case we are removing all manufacturers located in Japan
        // bikes.Remove("Suzuki");
        // bikes.Remove("Yamaha");
        // bikes.RemoveAt(0); //RemoveAt has no return value however
        //The updated list can then be iterated through using a foreach loop
        // Console.WriteLine("List of Non-Japanese Manufacturers:");
        // foreach (string manu in bikes)
        // {
        // Console.WriteLine("-" + manu);
        // }
    }

    public class Program
    {
        public static void Main(string[] args)
        {   
            // Notice the type for the new object reference
            // is the same as the class. name
            // Here mydeck mycard and myplayer are variables declared to be instances or objects of their classes. Invoking our class as a new object reference.
            Deck mydeck = new Deck();
            Card mycard = new Card("K","other",2);
            Player myplayer = new Player();
            List<string> cards = new List<string>(52);
            decks.shuffle(cards);

            Console.WriteLine("\n");
            Names();
            Console.WriteLine("\n");
            tossCoin(5);
        }
    
        public static void Names()
        {
            string[] names = { "0 Todd", "1 Tiffany", "2 Charlie", "3 Geneva", "4 Sydney" };
            Random rnd = new Random();
            int num;
            for (int i = 0; i < names.Length; i++)
            {
                num = rnd.Next(4);
                Console.WriteLine(names[num]);

            // Console.WriteLine(names[num]);

            }
        }
        public static void tossCoin(int numofToss)
        {
            Random rnd = new Random();
            int num;
            for(int i = 0; i < 10; i++)
            {
                num = rnd.Next(0,10);
                if(num < 5)
                {
                    Console.WriteLine(rnd.Next(0,10) + "  Heads");
                    //reset the random number with rnd.Next(0,10)
                    num = rnd.Next(0,10);
                }
                else if(num >= 5)
                {
                    Console.WriteLine(rnd.Next(0,10) + "  Tails");
                    num = rnd.Next(0,10);
                }
            }
            
        }
    }
}
