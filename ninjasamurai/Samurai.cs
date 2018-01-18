public class Samurai : Human
{
    private const int defaultHealth = 200;
    private static int SamuraiCount = 0;
    public Samurai(string person, int str, int intel, int dex) :base(person, str, intel, dex, defaultHealth)
    {
        SamuraiCount += 1;
    }

    public void DeathBlow(object someHuman)
    {
        if (someHuman is Human)
        {
            attack(someHuman);
            if ((someHuman as Human).health < 50)
            {
                (someHuman as Human).health = 0;
            }
        }
    }

    public void meditate()
    {
        health = defaultHealth;
    }

    public static int HowMany()
    {
        return SamuraiCount;
    }


}