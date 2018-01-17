using System;

public class Human
{
    // Assignment: Human
    // Let's get our feet wet with some OOP practice in C#! 
    // This first assignment shouldn't take us too much effort,
    // but that's ok since at this point we should be feeling pretty 
    // comfortable working with Classes and Objects.

    // Build a new .NET Project for this assignment as we will be revisiting in a later assignment.

    // Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health. 
    // Give a default value of 3 for strength, intelligence, and dexterity. Health should have a default of 100. 
    // When an object is constructed from this class it should have the ability to pass a name  Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.  Now add a new method called attack, which when invoked, should attack another Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker).  (Optional) Change the last function to accept any object and just make sure it is of type Human before applying damage. Hint you may need to refer back to the Boxing/Unboxing tab!
    public string name;
    private int strength;
    private int intelligence;
    private int dexterity;
    public int health;

    public Human()
    {
        name = "Folk";
        Initialize(3, 3, 3, 100);
    }

    public Human( string humanName)
    {
        name = humanName;
        Initialize(3, 3, 3, 100);
    }

    public Human( string humanName, int humanStrength, int humanIntelligence, int humanDexterity, int humanHealth)
    {
        name = humanName;
        Initialize(humanStrength, humanIntelligence, humanDexterity, humanHealth);
    }

    private  void Initialize(int humanStrength, int humanIntelligence, int humanDexterity, int humanHealth)
    {
        strength = humanStrength;
        intelligence = humanIntelligence;
        dexterity = humanDexterity;
        health = humanHealth;
    }

    public void Attack(object h)
    {
        if (h is Human && (h as Human).name == name)
            Console.WriteLine("Can't heart yourself!!!");

        if (h is Human && (h as Human).name != name)
            (h as Human).health -= (h as Human).strength * 5;
    }
}
