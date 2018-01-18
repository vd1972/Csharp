using System;

public class Wizard : Human
{
    private Random rand;
    public Wizard(string person, int str, int dex) :base(person, str, 25, dex, 50)
    {
        rand = new Random();
    }

    public void Heal()
    {
        health *= 10;
    }

    public void FireBall(object someHuman)
    {
        if (someHuman is Human)
        {
            (someHuman as Human).health -= rand.Next(20, 50);
        }

    }
}