public class Ninja : Human
{
    public Ninja(string person, int str, int intel, int hp) :base(person, str, intel, 175, hp)
    {

    }
    public void Steal(object someHuman)
    {
        attack(someHuman);
        health += 10;
    }

    public void GetAway()
    {
        health -= 15;
    }
}